using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    public GameObject[] foodPrefabs;
    public float spawnPozX = 0.1f;
    public float spawnPozY = 1.4f;
    public float spawnPozZ = -12.4f;
    public float startDelay = 0.1f;
    public float spawnInternal = 0.5f;

    
    void Start()
    {
        InvokeRepeating("FoodMove", startDelay, spawnInternal);
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void FoodMove()
    {
        int foodIndex = Random.Range(0, foodPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPozX, spawnPozX), spawnPozY, spawnPozZ);
       
        Instantiate(foodPrefabs[foodIndex], spawnPos, foodPrefabs[foodIndex].transform.rotation);
    }

    
}
