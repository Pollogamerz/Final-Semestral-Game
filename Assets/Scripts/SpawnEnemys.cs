using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnEnemys : MonoBehaviour
{
    public GameObject obstacule;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;
    [SerializeField] GameObject pauseMenu;




    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }

        

        if (pauseMenu.activeInHierarchy == true)
        {
            Time.timeScale = 0;
        }
    }


    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Instantiate(obstacule, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}

    
