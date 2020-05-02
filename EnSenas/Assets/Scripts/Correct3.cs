using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Correct3 : MonoBehaviour
{
    public float tempoInicio = 0;
    public float tempoFin = 2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tempoInicio += Time.deltaTime;
        if (tempoInicio >= tempoFin)
        {

            SceneManager.LoadScene("Preg4");
        }
    }
}
