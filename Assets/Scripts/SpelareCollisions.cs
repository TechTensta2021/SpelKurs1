using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpelareCollisions : MonoBehaviour
{
    public SpelareRorelse rorelse;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Hinder")
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
