using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUpanddown : MonoBehaviour
{
   
    Rigidbody rb;
    [SerializeField] float lenght;  // D�ugo�� ruchu
    [SerializeField] float speed;   // Pr�dko�� ruchu
    Vector3 startpos;  // Pozycja pocz�tkowa
    private enum Direction { horizontal, vertical };  // Typ kierunku
    [SerializeField] Direction selectDirection;  // Kierunek, w kt�rym porusza si� przeciwnik
    Vector3 direction;  // Kierunek ruchu

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startpos = rb.position;

        // Okre�lamy kierunek ruchu w zale�no�ci od wybranego typu
        if (selectDirection == Direction.vertical)
        {
            direction = Vector3.up;  // W g�r� i w d�
        }
        else
        {
            direction = Vector3.right;  // W lewo i w prawo
        }
    }

    void FixedUpdate()
    {
        // Ruch w zale�no�ci od wybranego kierunku
        rb.position = startpos + Mathf.Sin(Time.time * speed) * lenght * direction;
    }
}

