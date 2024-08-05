using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartScene()
    {
        SceneManager.LoadScene("Tutorial");

    }
    public void MenuPrincipal()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void ExitButton()
    {
        Debug.Log("salida");
        Application.Quit();
    }
}
