using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUpanddown : MonoBehaviour
{
   
    Rigidbody rb;
    [SerializeField] float lenght;  // D³ugoœæ ruchu
    [SerializeField] float speed;   // Prêdkoœæ ruchu
    Vector3 startpos;  // Pozycja pocz¹tkowa
    private enum Direction { horizontal, vertical };  // Typ kierunku
    [SerializeField] Direction selectDirection;  // Kierunek, w którym porusza siê przeciwnik
    Vector3 direction;  // Kierunek ruchu

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startpos = rb.position;

        // Okreœlamy kierunek ruchu w zale¿noœci od wybranego typu
        if (selectDirection == Direction.vertical)
        {
            direction = Vector3.up;  // W górê i w dó³
        }
        else
        {
            direction = Vector3.right;  // W lewo i w prawo
        }
    }

    void FixedUpdate()
    {
        // Ruch w zale¿noœci od wybranego kierunku
        rb.position = startpos + Mathf.Sin(Time.time * speed) * lenght * direction;
    }
}

