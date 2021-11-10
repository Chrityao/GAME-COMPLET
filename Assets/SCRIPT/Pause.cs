using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("GameClosed");
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
