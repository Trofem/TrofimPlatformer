using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    [SerializeField] private int n = 0;
    [SerializeField] private int nx = 0;
    private void Update()
    {
        if (n != 0)
        {
            if (DropdownController.Controller == "PS")
            {
                if (n == 1)
                {
                    if (Input.GetButtonDown("Cross"))
                    {
                        Quit();
                    }
                }
                if (n == 2)
                {
                    if (Input.GetButtonDown("Round"))
                    {
                        Quit();
                    }
                }
                if (n == 3)
                {
                    if (Input.GetButtonDown("Triangle"))
                    {
                        Quit();
                    }
                }
                if (n == 4)
                {
                    if (Input.GetButtonDown("Square"))
                    {
                        Quit();
                    }
                }
                if (n == 8)
                {
                    if (Input.GetButtonDown("Menu"))
                    {
                        Quit();
                    }
                }
                if (n == 9)
                {
                    if (Input.GetButtonDown("Option"))
                    {
                        Quit();
                    }
                }
            }
        }
        if (nx != 0)
        {
            if (DropdownController.Controller == "XBOX")
            {
                if (nx == 1)
                {
                    if (Input.GetButtonDown("B"))
                    {
                        Quit();
                    }
                }
                if (nx == 2)
                {
                    if (Input.GetButtonDown("X"))
                    {
                        Quit();
                    }
                }
                if (nx == 3)
                {
                    if (Input.GetButtonDown("Y"))
                    {
                        Quit();
                    }
                }
                if (nx == 4)
                {
                    if (Input.GetButtonDown("A"))
                    {
                        Quit();
                    }
                }
                if (nx == 7)
                {
                    if (Input.GetButtonDown("MenuXB"))
                    {
                        Quit();
                    }
                }
                if (nx == 9)
                {
                    if (Input.GetButtonDown("Option"))
                    {
                        Quit();
                    }
                }

            }
        }
    }
    public void Quit()
    {
        Application.Quit();
    }
}
