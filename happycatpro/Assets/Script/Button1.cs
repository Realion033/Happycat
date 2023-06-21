using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button1 : MonoBehaviour
{
  
    public void ControlKey()
    {
        SceneManager.LoadScene("seolmyeong");
    }

    public void Setting()
    {
        SceneManager.LoadScene("Setting");
    }

    public void MainScreen()
    {
        SceneManager.LoadScene("1_StartGame");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("2_GameScene");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("게임 종료");
    }
}
