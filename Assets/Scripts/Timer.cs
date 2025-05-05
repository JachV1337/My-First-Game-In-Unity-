using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;  // UI Text, w którym wyœwietlisz czas

    void Update()
    {
        // Ustawiamy tekst licznika na UI
        timerText.text = GameManager.GetFormattedTime();
    }
}
