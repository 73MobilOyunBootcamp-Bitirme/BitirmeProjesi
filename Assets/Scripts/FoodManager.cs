using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    public static FoodManager instance;

    public GameObject[] foodPrefabs;
    public float spawnPozX = 0.3f;
    public float spawnPozY = 1.7f;
    public float spawnPozZ = -12.0f;
    public float startDelay = 1.0f;
    public float spawnInternal = 1.0f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        //InvokeRepeating("FoodMove", startDelay, spawnInternal);

        
    }

    
    void Update()
    {
       
    }

    int foodIndex = 0;
    Vector3 spawnPos = Vector3.zero;

    public IEnumerator FoodMove()
    {
        while (GameManager.isGamestarted && !GameManager.isGameended) //Eğer oyun başladıysa ve oyun bitmediyse üretim yapılmaya devam edilir
        {


        yield return new WaitForSeconds(spawnInternal);

            foodIndex = Random.Range(0, foodPrefabs.Length);
            spawnPos.x = Random.Range(-spawnPozX, spawnPozX);
            spawnPos.y = spawnPozY; 
            spawnPos.z = spawnPozZ;

            Instantiate(foodPrefabs[foodIndex], spawnPos, foodPrefabs[foodIndex].transform.rotation, this.transform);

        }


    }

    





}
