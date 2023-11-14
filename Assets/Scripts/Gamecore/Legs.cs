using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legs : MonoBehaviour
{
    public static bool isLegs;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Terrain" || collision.gameObject.tag == "Platform")
        {
           isLegs = true;
           Debug.Log("exit Stand");
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Terrain" || collision.gameObject.tag == "Platform")
        {
           isLegs = false;
           Debug.Log("exit Stand");
        }
    }

}
