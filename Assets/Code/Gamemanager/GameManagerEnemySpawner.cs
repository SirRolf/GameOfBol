using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerEnemySpawner : MonoBehaviour {

    private float timer = 0;

    private float amountSpawning;

    private bool startSpawning = false;

    //starting amount of enemys that need to spawn that round
    [SerializeField]
    private float startAmountSpawning;
    //how long till the next enemy needs to spawn
    [SerializeField]
    private float spawnRate;
    //how many spawns the amount Rate rate grows by every wave
    [SerializeField]
    private float waveIncrease;
    //how long it takes till next wave will spawn
    [SerializeField]
    private float waveDowntime;

    //enemy prefeb
    [SerializeField]
    private GameObject enemyPrefab;

    void Awake ()
    {
        amountSpawning = startAmountSpawning;
    }

    void Update () {
        //timer
        timer += Time.deltaTime;

        //start spawning when you press space
        if(Input.GetKeyDown("space"))
        {
            startSpawning = true;
        }

        //check if its time to spawn and if you need to spawn more
        if(timer >= spawnRate && amountSpawning != 0 && startSpawning == true)
        {
            SpawnEnemy();
        }
        else if(timer >= waveDowntime && amountSpawning == 0)
        {
            EndWave();
        }
	}

    private void SpawnEnemy()
    {
        timer = 0;
        amountSpawning--;

        //spawn an enemy
        Instantiate(enemyPrefab, new Vector3(-8f, 0f, -.5f), Quaternion.identity);
    }

    private void EndWave()
    {
        print("downtime over");
        startAmountSpawning += waveIncrease;
        amountSpawning = startAmountSpawning;
        timer = 0;
        startSpawning = false;
    }
}
