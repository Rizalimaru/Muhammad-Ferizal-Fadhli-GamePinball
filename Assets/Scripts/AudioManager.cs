using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource bgm;
    public GameObject sfx;

    public GameObject SwitchOn;

    public GameObject SwitchOff;
    void Start()
    {
        PlayBGM();
    }
     private void PlayBGM()
     {
        bgm.Play();
     }

    public void PlaySFX(Vector3 spawnPosition)
     {
        GameObject.Instantiate(sfx, spawnPosition, Quaternion.identity);
     }
    
    public void PlaySwitchOn(Vector3 spawnPosition)
    {
        GameObject.Instantiate(SwitchOn, spawnPosition, Quaternion.identity);
    }
    public void PlaySwitchOff(Vector3 spawnPosition)
    {
        GameObject.Instantiate(SwitchOff, spawnPosition, Quaternion.identity);
    }
}
