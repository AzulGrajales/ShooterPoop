using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bullet;

    public float shortForce = 1500f;
    public float shortRate = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject newBullet;

            newBullet = Instantiate(bullet,spawnPoint.position, spawnPoint.rotation);
        }
    }
}
