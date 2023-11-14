using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDownPhysics : MonoBehaviour
{
    [SerializeField] private GameObject obj;

    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            ScrollBarPhysics.Jump_factor = 1f;
            ScrollBarPhysics.Move_factor = 1f;
            Debug.Log("Character is Classic");
            obj.SetActive(false);
        }
        if (val == 1)
        {
            Debug.Log("Character is Custom");
            obj.SetActive(true);
        }
    }
}
