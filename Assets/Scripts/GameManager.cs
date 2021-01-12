using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void OnLevelFinished()
    {
        Time.timeScale = 0;

        for (int i = 0; i < LevelManager.instance.LevelMalzeme.Count; i++)
        {
            for (int k = 0; k < LevelManager.instance.GameSandvic.Count; k++)
            {
                if (LevelManager.instance.LevelMalzeme[i].tag.Contains(LevelManager.instance.GameSandvic[k].tag))
                {
                    Debug.Log("başarılı");
                }
                else
                    Debug.Log("Fail");
            }
        }
    }

    public void OnLevelSuccessed()
    {

    }
}
