using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSlide : MonoBehaviour
{
    public static bool isLeftSlide;
    private void Awake()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Terrain" || collision.gameObject.tag == "Platform")
        {
            isLeftSlide = true;
            Debug.Log("enter Left Sliding");
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Terrain" || collision.gameObject.tag == "Platform")
        {
            isLeftSlide = false;
            Debug.Log("exit Left Sliding");
        }
    }

}
