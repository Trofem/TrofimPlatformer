using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToMenu : MonoBehaviour
{
    [SerializeField] private float waitTimer_;
    public static float waitTimer;
    public static float temp;
    [SerializeField] private string level = "Start Screen";
    // Start is called before the first frame update
    void Start()
    {
        waitTimer = waitTimer_;
        temp = waitTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("EX"))
        {
            waitTimer = temp;
        }

        if (Input.GetButton("EX"))
        {
            if (waitTimer <= 0)
            {
                SceneManager.LoadScene(level);
            }
            else
            {
                Debug.Log("wait time = " + waitTimer);
                waitTimer -= Time.deltaTime;
            }
        }
    }
    public void ExitingButton()
    {
        SceneManager.LoadScene(level);
    }
}
