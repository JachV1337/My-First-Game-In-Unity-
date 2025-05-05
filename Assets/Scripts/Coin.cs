using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    public int CoinN;
    public TextMeshProUGUI CoinDisplay;
    // Start is called before the first frame update
    void Start()
    {
        UpdateCoinCountText();
        
    }

    public void Coins()
    {
        CoinN++;
        UpdateCoinCountText();
    }


    void Awake()
    {
        if (FindObjectsOfType<Coin>().Length > 99)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject); // Zapewnia, ¿e obiekt bêdzie trwa³ przez wszystkie sceny
        }
    }

    private void UpdateCoinCountText()
    {
        
        if (CoinDisplay != null)
        {
            CoinDisplay.text = "Coins: " + CoinN.ToString();

        }
        else
        {
            Debug.LogWarning("CoinCountText is not assigned!");  // Ostrze¿enie, jeœli nie przypisano Text UI
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
