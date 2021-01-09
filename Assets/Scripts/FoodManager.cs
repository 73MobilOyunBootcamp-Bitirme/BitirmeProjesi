using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    public GameObject[] foodPrefabs;
    public float spawnPozX = 0.3f;
    public float spawnPozY = 1.7f;
    public float spawnPozZ = -12.0f;
    public float startDelay = 1.0f;
    public float spawnInternal = 1.0f;

    
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
