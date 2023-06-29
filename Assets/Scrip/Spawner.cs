using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int counter;
    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemy", 0, 1f);
    }

    public void spawnEnemy()
    {
        if (--counter == 0) CancelInvoke("spawnEnemy");
        Instantiate(enemies[Random.Range(0, enemies.Length)], new Vector3(Random.Range(0, 5), Random.Range(0, 5), Random.Range(0, 5)), Quaternion.identity);
    }
}
