using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlovalVariableCallback : MonoBehaviour
{

    public int callToGlobal;

    // This is how fuckin use variable from different script
    void Update()
    {
        //callToGlobal = ItemCollector.strawberries;
        //Debug.Log("Strawberry Number " + callToGlobal);
    }
}
