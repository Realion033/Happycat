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
}
