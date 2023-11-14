using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private int number;
    public static int variable;
    private bool flag;
    // Start is called before the first frame update
    void Start()
    {
        variable = 0;
        flag = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player" && flag == true)
        {
            Debug.Log("variable" + variable);
            variable = number;
            flag = false;
        }
    }
}