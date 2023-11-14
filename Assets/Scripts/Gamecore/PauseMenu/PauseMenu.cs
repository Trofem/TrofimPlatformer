using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    public GameObject Obj;
    public PauseRandomTip randomTip;
    public void Start()
    {
        Resume();
        randomTip = Obj.GetComponent<PauseRandomTip>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Menu"))
        {
            SwapMenu();
        }
    }
    public void Resume()
    {
        if (GameIsPaused)
        {
            randomTip.RandomTip();
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }
    }
    public void Pause()
    {
        if (!GameIsPaused)
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
    }
    public void SwapMenu()
    {
        if (GameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

}
