using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] int Strenght;
    [SerializeField] ParticleSystem particles;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        other.GetComponent<Rigidbody>().AddForce(Vector3.up * Strenght, ForceMode.VelocityChange);
        Instantiate (particles,transform.position, Quaternion.identity);
    }
}
