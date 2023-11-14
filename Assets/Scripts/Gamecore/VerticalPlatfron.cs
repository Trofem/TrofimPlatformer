using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPlatfron : MonoBehaviour
{
    private PlatformEffector2D effector;
    private float waitTime;

    private void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Legs.isLegs = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        Legs.isLegs = false;
    }
    // Update is called once per frame
    private void Update()
    {
            if (Input.GetKeyDown(DropDownKeybinds.Key_Down) || Input.GetButtonDown(DropdownController.Cont_Down))
            {
                waitTime = 0.5f;
            }

            if (Input.GetKey(DropDownKeybinds.Key_Down) || Input.GetButton(DropdownController.Cont_Down))
            {
                if (waitTime <= 0)
                {
                    effector.rotationalOffset = 180f;
                    waitTime = 0.5f;
                }
                else
                {
                    waitTime -= Time.deltaTime;
                }
            }
            if (Input.GetKeyUp(DropDownKeybinds.Key_Up) || Input.GetButtonUp(DropdownController.Cont_Up))
            {
                effector.rotationalOffset = 0f;
            }
    }
}