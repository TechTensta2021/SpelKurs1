using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolja : MonoBehaviour
{

    public Transform spelare;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = spelare.position + offset;
    }
}
