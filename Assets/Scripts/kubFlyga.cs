using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kubFlyga : MonoBehaviour
{
    public Rigidbody rb;
    public float kraft = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(0, kraft * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
    }
}
