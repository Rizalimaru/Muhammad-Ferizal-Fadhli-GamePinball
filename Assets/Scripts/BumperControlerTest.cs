using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperControlerTest : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider bola;
    public float multiplier;
    public Color color;
    void Start()
    {
        GetComponent<Renderer>().material.color = color;
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;
        }
    }
  
}
