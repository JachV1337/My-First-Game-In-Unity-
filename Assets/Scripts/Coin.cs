using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    public static Coin Instance;
    public int CoinN;
    public TextMeshProUGUI CoinDisplay;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        UpdateCoinCountText();
    }

    // Ta metoda jest wywo≥ywana gdy scena jest za≥adowana
    void OnLevelWasLoaded(int level)
    {
        // Znajdü nowy TextMeshProUGUI w nowej scenie
        CoinDisplay = GameObject.FindGameObjectWithTag("CoinDisplay")?.GetComponent<TextMeshProUGUI>();
        UpdateCoinCountText();
    }

    public void AddCoin()
    {
        CoinN++;
        UpdateCoinCountText();
    }

    private void UpdateCoinCountText()
    {
        if (CoinDisplay != null)
        {
            CoinDisplay.text = "Coins: " + CoinN.ToString();
        }
        else
        {
            Debug.LogWarning("CoinCountText is not assigned!");
        }
    }
}
