using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class DeathCounter : MonoBehaviour

   
{

    public TextMeshProUGUI deathCountText;
    private void Start()
    {
        UpdateDeathCountText();
    }
    public void Death()
    {
        GameManager.deathCount++;
        UpdateDeathCountText();
        

    }
    
        void Awake()
        {
            if (FindObjectsOfType<DeathCounter>().Length > 99)
            {
                Destroy(gameObject);
            }
            else
            {
                DontDestroyOnLoad(gameObject); // Zapewnia, ¿e obiekt bêdzie trwa³ przez wszystkie sceny
            }
        }
    

    private void UpdateDeathCountText()
    {
        if (deathCountText != null)
        {
            deathCountText.text = "Deaths: " + GameManager.deathCount.ToString();
            
        }
        else
        {
            Debug.LogWarning("deathCountText is not assigned!");  // Ostrze¿enie, jeœli nie przypisano Text UI
        }
    }
    public void SetInitialDeathCount()
    {
    UpdateDeathCountText();
    }
}






