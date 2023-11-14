using UnityEngine;
public class Buff : MonoBehaviour
{
    [SerializeField] private float speed = 0;
    [SerializeField] private float force = 0;
    [SerializeField] private bool onbuff = true;
    [SerializeField] private bool ismultiple = false;
    private bool flag;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (flag && collision.gameObject.tag == "Player")
        {
            if (onbuff)
            {
                PlayerMovement.moveSpeed += speed;
                PlayerMovement.jumpForce += force;
                Debug.Log("In Buff, movespeed buffed = " + PlayerMovement.moveSpeed + " and JumpForce buffed = " + PlayerMovement.jumpForce);
                onbuff = ismultiple;
            }
        }
        if (ismultiple){
            flag = true;
        }
        else{
            flag = false;
        }
    }
}