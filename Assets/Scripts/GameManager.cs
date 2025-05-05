using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;
    public static int deathCount = 0;
    public static float timeValue = 0f;
    public static int CoinN = 0;
    public static void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public static void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Zapewnia, ¿e obiekt nie zostanie zniszczony podczas zmiany sceny
        }

        else
        {
            Destroy(gameObject); // Zniszczenie, jeœli ju¿ istnieje instancja
        }
    }
    private void Update()
    {
        // Liczenie czasu w tle (w ka¿dej scenie)
        timeValue += Time.deltaTime;
    }

    // Metoda do uzyskania aktualnego czasu
    public static string GetFormattedTime()
    {
        int seconds = Mathf.FloorToInt(timeValue % 60);
        int minutes = Mathf.FloorToInt((timeValue / 60) % 60);
        int hours = Mathf.FloorToInt((timeValue / 3600) % 24);
        return string.Format("{0:00}:{1:00}", minutes, seconds);  // Format MM:SS
    }
    public static float GetTime()
    {
        return timeValue;

    }
    public static int GetDeath()
    {
        return deathCount;
    }
    public static void ResetGameData()
    {
        deathCount = 0;
        timeValue = 0f;
    }
    
}



