using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSavedLevel : MonoBehaviour
{
    public static string Scene;
    [SerializeField] private Text gameText;
    [SerializeField] private string[] buttonText; 
    public static bool FromMenu;
    private void Start()
    {

        if (IsContinue())
        {
            FromMenu = true;
            gameText.text = buttonText[1];
            Debug.Log("Game has a savefile of level " + SaveSystem.level + " and " + SaveSystem.allStrawberries + " stawberries.");
        }
        else
        {
            FromMenu = false;
            gameText.text = buttonText[0];
        }
    }
    public void LoadingLevel()
    {
        if (IsContinue())
        {
            Debug.Log("Save is loaded!");
            SceneManager.LoadScene(SaveSystem.level);
        }
        else
        {
            Debug.Log("Game is starts");
            SceneManager.LoadScene(Scene);
        }
    }
    public static bool IsContinue()
    {
        if (SaveSystem.level != "" && SaveSystem.allStrawberries != -1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
