using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBoccia : MonoBehaviour
{
    private Vector3 velocity;
    private Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody>();
        velocity = rb.velocity;
        if ((velocity.magnitude < 0.5) && (velocity.magnitude > -0.5))
        {
            velocity.Set(0,0,0);
        }
        GetComponent<Rigidbody>().velocity = velocity;
    }
}
