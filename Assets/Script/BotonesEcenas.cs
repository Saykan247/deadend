using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesEcenas : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }


    public void CargarNivel(string nombreNivel)
    {
        SceneManager.LoadScene(nombreNivel);
    }
    public void Salir()
    {
        Application.Quit();
    }
}