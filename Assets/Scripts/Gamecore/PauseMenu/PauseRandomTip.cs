using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseRandomTip : MonoBehaviour
{
    [SerializeField] private string[] randomTips;
    private int num;
    [SerializeField] private Text tipText;
    void Start()
    {
        tipText.text = randomTips[0];
        foreach (string s in randomTips)
        {
            Debug.Log("Tip " + randomTips.Length + " : " + s);
        }
        Debug.Log("length of tips are: " + randomTips.Length);

    }
    public void RandomTip()
    {
        num++;
        if (num > randomTips.Length)
        {
            num = 0;
        }
        tipText.text = randomTips[num] + ".";
        Debug.Log("Random tip " + num + " : " + randomTips[num] + ".");
    }
}
