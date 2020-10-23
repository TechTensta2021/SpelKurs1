using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Poang : MonoBehaviour
{
    public Transform Spelare;
    public Text poangText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        poangText.text = Spelare.transform.position.z.ToString("0");
    }
}
