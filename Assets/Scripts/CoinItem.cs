using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinItem : MonoBehaviour
{

    void OnTriggerEnter(Collider other)   {



        if (other.CompareTag("Gracz"))
        {
            Coin.Instance.AddCoin();
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
