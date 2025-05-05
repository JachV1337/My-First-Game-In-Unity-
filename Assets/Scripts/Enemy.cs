using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float lenght;
    [SerializeField] float speed;
    Vector3 startpos;
    private enum Direction { horizontal, vertical };
    [SerializeField] Direction selectDirection;
    Vector3 direction;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startpos = rb.position;
        if (selectDirection == Direction.vertical)
        {
            direction = Vector3.forward;
        }
        else
        {
            direction = Vector3.right;
        }
    }


    void FixedUpdate()
    {
        rb.position = startpos + Mathf.Sin(Time.time * speed) * lenght * direction; 
    }
}
