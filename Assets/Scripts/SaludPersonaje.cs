using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaludPersonaje : MonoBehaviour
{

    public float Salud = 100;
    public float SaludMax = 100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void RecibirDa�o(float da�o)
    {
        Salud -= da�o;

        if (Salud <= 0)
        {
            SceneManager.LoadScene(0);
            Destroy(gameObject);
        }

    }

}