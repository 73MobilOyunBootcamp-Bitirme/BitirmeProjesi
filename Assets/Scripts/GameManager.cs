using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    /// <summary>
    /// GameManager scriptinin instance 'ı
    /// </summary>
    public static GameManager instance;

    /// <summary>
    /// Oyunun başlamasını kontrol eden bool
    /// </summary>
    public static bool isGamestarted = false;
    /// <summary>
    /// Oyunun bitişini kontrol eden bool
    /// </summary>
    public static bool isGameended = false;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

       
    }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(1);

        isGamestarted = true;

        StartCoroutine(FoodManager.instance.FoodMove());
    }

    void Update()
    {
        
    }
}
