using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string controllerSceneName;

    public void GoToController()
    {
        SceneManager.LoadScene(controllerSceneName);
    }

    public void GoToNextMindHub()
    {
        SceneManager.LoadScene("Hub");
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
