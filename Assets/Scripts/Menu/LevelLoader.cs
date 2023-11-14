using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transTime = 1f;
    private bool flag;
    public GameObject obj;

    public static bool isAnimDeadPlayed = false;
    public static bool isAnimFinishPlayed = false;
    private void Awake()
    {
        flag = true;
        isAnimDeadPlayed = false;
        isAnimFinishPlayed = false;
        transition = GetComponent<Animator>();
    }
    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (PlayerMovement.died && flag)
        {
            StartCoroutine(RestartingLevel());
        }
        else if (Finish.levelCompleted && flag)
        {
            StartCoroutine(EndingLevel());  
        }
    }
    IEnumerator RestartingLevel()
    {
        flag = false;
        Debug.Log("Before");
        yield return new WaitForSeconds(transTime);
        transition.SetTrigger("Start");
        Debug.Log("After");
        yield return new WaitForSeconds(transTime);
        isAnimDeadPlayed = true;
    }
    IEnumerator EndingLevel()
    {
        flag = false;
        Debug.Log("Ending");
        yield return new WaitForSeconds(transTime);
        transition.SetTrigger("Start");
        Debug.Log("Ending second");
        yield return new WaitForSeconds(transTime);
        isAnimFinishPlayed = true;
    }
    IEnumerator OnVariable(bool flag)
    {
        yield return new WaitForSeconds(1f);
        flag = true;
        obj.SetActive(true);
    }
}
