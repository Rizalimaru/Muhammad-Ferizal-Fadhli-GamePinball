using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;

    public ScoreManager scoreManager;
    public float score;

    public AudioManager audioManager;
    public VFXManager VFXManager;

    private Renderer rend;
    private Animator animator;

    
    private void Start()
    {
        rend = GetComponent<Renderer>();
        animator = GetComponent<Animator>();

         // Change to rend.material.color
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            animator.SetTrigger("Hit");
            rend.material.color = color;
            audioManager.PlaySFX(collision.transform.position);
            VFXManager.PlayVFX(collision.transform.position);
            scoreManager.AddScore(score);
        }
    }
}
