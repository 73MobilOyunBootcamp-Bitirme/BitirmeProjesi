using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

    public GameObject winPanel;
    public GameObject LostPanel;


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
                    OnLevelSuccessed();
                    Debug.Log("başarılı");
                }
                else
                {
                    OnLevelFail();
                    Debug.Log("Fail");
                }
                    
            }
        }
    }

    public void OnLevelSuccessed()
    {
        winPanel.SetActive(true);
    }

    public void OnLevelFail()
    {
        LostPanel.SetActive(true);
    }

    public void nextButtonActive()
    {

    }

    public void restartButtonActive()
    {

    }
}
