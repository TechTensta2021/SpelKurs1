using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vinna : MonoBehaviour
{
    public GameObject DuVinnerText;
    public float tidInnanNextLevel;
    private void OnTriggerEnter(Collider other)
    {
        DuVinnerText.SetActive(true);
        Invoke("loadLevel", tidInnanNextLevel);
    }

    void loadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
