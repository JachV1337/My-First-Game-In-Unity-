using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void ButtonQuitGamePressed()
    {
        Debug.Log("wyjscie z gry");
        Application.Quit();
    }
    public void ButtonPlayPressed()
    {
        GameManager.LoadNextLevel();
    }
    public void ButtonContinuePressed()
    {
        SceneManager.LoadScene(0); //od nowa (doda� resetowanie sie czasu i �mierci)
        GameManager.ResetGameData();
    }
}
