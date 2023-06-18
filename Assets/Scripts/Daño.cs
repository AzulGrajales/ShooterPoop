using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour
{
    public float NumDaño;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.GetComponent<SaludPersonaje>())
        {
            other.GetComponent<SaludPersonaje>().RecibirDaño(NumDaño);

        }
    }
}