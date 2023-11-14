using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDownKeybinds : MonoBehaviour
{
    public static string Key_Up = "w";
    public static string Key_Down = "s";
    public static string Move_Axis = "Horizontal";
    public static string Key_Binds = "Keybind0";
    private void Start()
    {
        if (Key_Binds == "None")
        {
            KeyBind("w", "s", "Horizontal");
            Key_Binds = "Keybind0";
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown("l"))
        {
            KeyBind("space", "s", "Horizontal");
            Key_Binds = "Keybind0";
        }
    }
    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            KeyBind("", "", "");
            Key_Binds = "None";
        }
        if (val == 1)
        {
            KeyBind("w", "s", "Horizontal");
            Key_Binds = "Keybind1";
        }
        if (val == 2)
        {
            KeyBind("up", "down", "HorizontalArrow");
            Key_Binds = "Keybind2";
        }
        if (val == 3)
        {
            KeyBind("space", "s", "Horizontal");
            Key_Binds = "Keybind0";
        }

    }
    private void KeyBind(string Up, string Down, string Axis)
    {
        Key_Up = Up;
        Key_Down = Down;
        Move_Axis = Axis;
        Debug.Log("Setting are implemented! " + Key_Up + " " + Key_Down + " " + Move_Axis + ".");
    }
}
