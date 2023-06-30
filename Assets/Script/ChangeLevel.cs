using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public string nameLevel;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && gameObject.tag != "Exit")
        {
            NextLevel();
        }
        else if (other.CompareTag("Player") && gameObject.tag == "Exit")
        {
            ExitGame();
        }
    }


    void NextLevel()
    {
        SceneManager.LoadScene(nameLevel);
    }
    void ExitGame()
    {
        Application.Quit();
        Debug.Log("has salido del juego");
    }
}
