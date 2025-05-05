using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndDeath : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI DeathEND;
    private void Start()
    {
        int deathCount = GameManager.GetDeath();
        DeathEND.text = "Deaths: " + deathCount.ToString();  // Wyœwietlanie liczby œmierci
    }
}
