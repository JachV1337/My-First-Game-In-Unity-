using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.ParticleSystem;
using UnityEngine.UI;
using System;

public class Gracz : MonoBehaviour
{

    [SerializeField] ParticleSystem particles;
    [SerializeField] int posY = 5;
    [SerializeField] int speed = 10;
    Rigidbody rb;
    Vector3 input;
    [SerializeField] int BasicmaxSPEED;
    [SerializeField] GameObject Meta;
    [SerializeField] public static int CoinNum;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        

    }

    private void Update()
    {
        float Hdirection;
        float Vdirection;

        if (rb && (Hdirection = Input.GetAxis("Horizontal")) != 0)
        {
            rb.AddTorque(0, 0, -Hdirection * Time.deltaTime * speed);

        }


        if (rb && (Vdirection = Input.GetAxis("Vertical")) != 0)
        {
            rb.AddTorque(Vdirection * Time.deltaTime * speed, 0, 0);
        }
        if (rb.maxAngularVelocity > BasicmaxSPEED)
        {
            rb.maxAngularVelocity = BasicmaxSPEED;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu menu = FindObjectOfType<PauseMenu>();
            if (menu != null)
            {
                menu.Pause();
            }
            else
            {
                Debug.LogError("Nie znaleziono obiektu z PauseMenu w scenie!");
            }
        }

        if (Input.GetKey(KeyCode.R) || transform.position.y < -6)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            FindObjectOfType<DeathCounter>().Death();
        }
    }
        void FixedUpdate()
        {
        if (rb.velocity.magnitude < BasicmaxSPEED)
        {
            rb.AddForce(input * speed * Time.fixedDeltaTime);
        }
        else
        {

        }
    }

    //Przejscie i œmierc
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Meta)
        {
            GameManager.LoadNextLevel();
        }
        if (collision.gameObject.GetComponent<Enemy>() != null || (collision.gameObject.GetComponent<Trap>() != null) || (collision.gameObject.GetComponent<EnemyUpanddown>() != null))
        {



            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            FindObjectOfType<DeathCounter>().Death();


        }

        if (collision.gameObject.GetComponent<Enemy>() || collision.gameObject.GetComponent<Trap>())
        {
            Instantiate(particles, transform.position, Quaternion.identity);
        }
        else
        {

        }
        

    }
   
    






}