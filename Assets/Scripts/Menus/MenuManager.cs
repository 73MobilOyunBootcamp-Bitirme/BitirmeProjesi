using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static void GoToMenu(MenuName name)
    {
        switch (name)
        {
            case MenuName.Main:
                //go to MainMenu scene
                SceneManager.LoadScene("MainMenu");
                break;
            case MenuName.Pause:
                //instantiate prefab
                Object.Instantiate(Resources.Load("PauseMenu"));
                break;
        }
    }
}
