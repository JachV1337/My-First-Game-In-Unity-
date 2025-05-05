using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    
    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
       
    }
    public void Continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
        
    }
    public void Restart()
    {
        GameManager.deathCount = 0;
        GameManager.timeValue = 0f;
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void StartMenu()
    {
        SceneManager.LoadScene(0);
    }
}
