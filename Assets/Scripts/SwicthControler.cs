using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SwicthControler : MonoBehaviour
{ private enum SwitchState
  {
    Off,
    On,
    Blink
  }

  public Collider bola;
  public Material offMaterial;
  public Material onMaterial;
  public AudioManager audioManager;
  public ScoreManager scoreManager;
  public float score;
  private SwitchState state;
  private Renderer rend;

  public VFXManager VFXManager;

  private Animation animator;

  private void Start()
  {
    rend = GetComponent<Renderer>();
    animator = GetComponent<Animation>();

    Set(false);

    StartCoroutine(BlinkTimerStart(5));
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other == bola)
    {
      Toggle();
      VFXManager.PlayVFX(transform.position);
    }
  }

  private void Set(bool active)
  {
    if (active == true)
    {
      
      state = SwitchState.On;
      rend.material = onMaterial;
      StopAllCoroutines();
      
   
    }
    else
    {
      
      state = SwitchState.Off;
      rend.material = offMaterial;
      StartCoroutine(BlinkTimerStart(5));
      
    }
  }

  private void Toggle()
  {
    if (state == SwitchState.On)
    {
      audioManager.PlaySwitchOn(transform.position);
      Set(false);
      
    }
    else
    {
      audioManager.PlaySwitchOff(transform.position);
      Set(true);
      
    }
    scoreManager.AddScore(score);
  }

  private IEnumerator Blink(int times)
  {
    state = SwitchState.Blink;

    for (int i = 0; i < times; i++)
    {
      rend.material = onMaterial;
      yield return new WaitForSeconds(0.5f);
      rend.material = offMaterial;
      yield return new WaitForSeconds(0.5f);
    }

    state = SwitchState.Off;

    StartCoroutine(BlinkTimerStart(5));
  }

  private IEnumerator BlinkTimerStart(float time)
  {
    yield return new WaitForSeconds(time);
    StartCoroutine(Blink(2));
  }


}
