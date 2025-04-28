using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    public void Restart()
    {
     UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
