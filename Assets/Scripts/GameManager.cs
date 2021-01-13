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
    public Text LevelText;

    public List<Image> LifeImages = new List<Image>();
    public static int PlayerLife = 3;


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

        if(LevelManager.instance.LevelMalzeme.Count == LevelManager.instance.GameSandvic.Count)
        {
            OnLevelSuccessed();
        }
        
    }

    public void OnLevelSuccessed()
    {
        isGameended = true;
        Destroy(FoodManager.instance.gameObject);
        winPanel.SetActive(true);

    }

    public void OnLevelFail()
    {
        isGameended = true;
        Destroy(FoodManager.instance.gameObject);
        LostPanel.SetActive(true);
    }

    public void nextButtonActive()
    {
        winPanel.SetActive(false);
        LevelManager.instance.LevelNumber++;
        SceneManager.LoadScene(0);
        LevelText.text = "Level " + LevelManager.instance.LevelNumber;
        Time.timeScale = 1;
    }

    public void restartButtonActive()
    {
        LostPanel.SetActive(false);
        SceneManager.LoadScene(0);
        LevelText.text = "Level " + LevelManager.instance.LevelNumber;
        Time.timeScale = 1;
    }

    public void IncreaseLife()
    {
        if(LifeImages[0] != null)
        {
            LifeImages[0].gameObject.SetActive(false);
            LifeImages.RemoveAt(0);
        }
          
    }
}
