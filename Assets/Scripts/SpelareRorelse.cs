using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpelareRorelse : MonoBehaviour
{
    public Rigidbody rb;

    public float kraftFram = 2000f;
    public float kraftSidor = 500f;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, kraftFram * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(kraftSidor * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-kraftSidor * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
