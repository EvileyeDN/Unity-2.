using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimela", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimela();
        }
    }
    void SpawnRandomAnimela()
    {
        int animalindex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnpos = new Vector3(-20, 0, Random.Range(1, 22));
        Instantiate(animalPrefabs[animalindex], spawnpos, animalPrefabs[animalindex].transform.rotation);
    }
}
