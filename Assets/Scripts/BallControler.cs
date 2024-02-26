using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControler : MonoBehaviour
{
    private Rigidbody rig;
    public float maxSpeed;
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rig.velocity.magnitude >maxSpeed)
        {

            rig.velocity = rig.velocity.normalized * maxSpeed;
        }
    }
}
