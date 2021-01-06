using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 0;
    }
    public void OnResumeButtonClick()
    {
        Time.timeScale = 1;
        Destroy(gameObject);
    }
    public void OnQuitButtonClick()
    {
        Time.timeScale = 1;
        Destroy(gameObject);
        MenuManager.GoToMenu(MenuName.Main);
    }
}
