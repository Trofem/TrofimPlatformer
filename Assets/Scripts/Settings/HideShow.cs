using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideShow : MonoBehaviour
{
    public GameObject obj;

    // Start is called before the first frame update
    void Awake()
    {
        Show();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Show()
    {
        obj.SetActive(true);
    }
    public void Hide()
    {
        obj.SetActive(false);
    }
}
