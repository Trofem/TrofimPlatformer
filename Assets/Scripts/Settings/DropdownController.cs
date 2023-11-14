using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownController: MonoBehaviour
{
    public static string Cont_Up = "Cross";
    public static string Cont_Down = "Round";
    public static string Cont_Horizontal = "HorizontalPS";

    public static string Controller = "";
    public bool isPreff = false;
    private void Awake()
    {
        if (isPreff && Controller == "Never Gonna Give You Up")
        {
            ControlBind("Cross", "Round", "PHorizontalStick");
            Controller = "PS";
            Debug.Log("Controller from none to settings of PS");
        }
    }
    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            ControlBind("", "", "");
            Controller = "";
            Debug.Log("Controller none");
        }
        if (val == 1)
        {
            ControlBind("Cross", "Round", "HorizontalPS");
            Controller = "PS";
            Debug.Log("Controller PS with Dpad(Dualshock/Sence)");
        }
        if (val == 2)
        {
            ControlBind("Cross", "Round", "PHorizontalStick");
            Controller = "PS";
            Debug.Log("Controller PS with stick (Dualshock/Sence)");
        }
        if (val == 3)
        {
            ControlBind("A", "B", "HorizontalXB");
            Controller = "XBOX";
            Debug.Log("Controller Xbox with Dpad");
        }
        if (val == 4)
        {
            ControlBind("A", "B", "XHorizontalStick");
            Controller = "XBOX";
            Debug.Log("Controller Xbox with stick");
        }
    }
    private void ControlBind(string Up, string Down, string Horizontal)
    {
        Cont_Up = Up;
        Cont_Down = Down;
        Cont_Horizontal = Horizontal;
    }
}
