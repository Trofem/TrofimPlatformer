using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    [SerializeField] private float bounce = 20f;
    private float jp;
    private bool b = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player" && b)
        {
            jp = PlayerMovement.jumpfull;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce * jp, ForceMode2D.Impulse);
            if (jp != 1f)
            {
                Debug.Log("bounce jp equal = " + bounce * jp);
            }
            else
            {
                Debug.Log("bounce equal" + bounce);
            }

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        b = true;
    }
}