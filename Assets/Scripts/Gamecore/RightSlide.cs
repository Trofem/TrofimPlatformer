using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSlide : MonoBehaviour
{
    public static bool isRightSlide;
    private void Awake()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Terrain" || collision.gameObject.tag == "Platform")
        {
            isRightSlide = true;
            Debug.Log("enter Right Sliding");
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Terrain" || collision.gameObject.tag == "Platform")
        {
            isRightSlide = false;
            Debug.Log("exit Right Sliding");
        }
    }

}
