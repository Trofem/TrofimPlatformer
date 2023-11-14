using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDownImmortal : MonoBehaviour
{
    public static bool immortal = false;

    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            immortal = false;
            Debug.Log("Character mortal");
        }
        if (val == 1)
        {
            immortal = true;
            Debug.Log("Character immortal");
        }
    }
}
