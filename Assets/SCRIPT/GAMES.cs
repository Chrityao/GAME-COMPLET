using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GAMES : MonoBehaviour
{
    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void FlappyBirdButton()
    {
        SceneManager.LoadScene("Flappy Bird");
    }
    public void TetrisButton()
    {
        SceneManager.LoadScene("Tetris");
    }
    public void SnakeButton()
    {
        SceneManager.LoadScene("Snake");
    }
}
