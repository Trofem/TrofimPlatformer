using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public static string level = "Tutorial";
    public static int allStrawberries = -1;
    [SerializeField] private int act;
    public GameObject obj;
    private void Start()
    {
        if (act == 1)
        {
            SavePrefs();
        }
        else if (act == 2)
        {
            LoadPrefs();
        }
        else if (act == 3)
        {
            DeleteData();
        }
    }
    public void SavePrefs()
    {
        LoadSavedLevel.FromMenu = true;
        level = ItemCollector.SceneName;
        allStrawberries = ItemCollector.allstrawberries - ItemCollector.strawberries;
        PlayerPrefs.SetString("Level", level);
        PlayerPrefs.SetInt("allStrawberries", allStrawberries);
    }
    public void LoadPrefs()
    {
        LoadSavedLevel.FromMenu = true;
        LoadSavedLevel.Scene = PlayerPrefs.GetString("Level");
        allStrawberries = PlayerPrefs.GetInt("allStrawberries");
        ItemCollector.allstrawberries = allStrawberries;
    }
    public void DeleteData()
    {
        LoadSavedLevel.FromMenu = false;
        PlayerPrefs.DeleteAll();
        Debug.LogError("Save deleted!");

    }
}
