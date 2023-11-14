using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform point;
    [SerializeField] private float waitTime = 10f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entered");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("teleporting");
            if (waitTime <= 0)
            {
                collision.transform.position = point.transform.position;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
    
}
