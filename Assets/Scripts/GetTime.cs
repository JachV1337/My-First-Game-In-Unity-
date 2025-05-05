using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GetTimeEnd : MonoBehaviour
   
{
    [SerializeField] private TextMeshProUGUI TextTimeEND;
    void Start()
    {
        // Pobieramy czas z GameManager i przekonwertowujemy na format string
        float timeValue = GameManager.GetTime(); // Zwrócony czas (float)

        // Konwersja czasu na minut:sekund w formacie mm:ss
        int minutes = Mathf.FloorToInt(timeValue / 60);  // Liczba minut
        int seconds = Mathf.FloorToInt(timeValue % 60); // Liczba sekund

        // Formatowanie czasu w string i przypisanie go do TextMeshPro
        string formattedTime = string.Format("{0:00}:{1:00}", minutes, seconds);
        TextTimeEND.text = formattedTime;  // Ustawiamy tekst w UI
    }
}
