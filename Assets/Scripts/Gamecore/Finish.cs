using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;
    [SerializeField] private string level = "SecondLevel";
    public static bool levelCompleted = false;
    // Start is called before the first frame update
    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            finishSound.Play();
            levelCompleted = true;
            Debug.Log("level finished");
        }
    }
    private void Update()
    {
        if (levelCompleted && LevelLoader.isAnimFinishPlayed)
        {
            levelCompleted = false;
            CompleteLevel();
        }
    }

    private void CompleteLevel()
    {
        Debug.Log("level is loading");
        SceneManager.LoadScene(level);
    }
}
