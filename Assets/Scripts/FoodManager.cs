using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    public GameObject[] foodPrefabs;
    public float spawnPozX = 3.5f;
    public float spawnPozY = 10.0f;
    public float startDelay = 0.1f;
    public float spawnInternal = 0.5f;

    private float lowerBound = 2f;
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
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPozX, spawnPozX), spawnPozY, 0);
       
        Instantiate(foodPrefabs[foodIndex], spawnPos, foodPrefabs[foodIndex].transform.rotation);
    }

    
}
