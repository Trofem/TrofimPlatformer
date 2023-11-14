using UnityEngine;
public class PlayerMovement : MonoBehaviour
{   //контроллер controller
    //float переменные:
    public static float jumpfull = 1f;
    public static float movefull = 1f;
    public static float moveSpeed;
    public static float jumpForce;
    private float dirXcontroller = 0f;
    private float MainDirX = 0f;
    public float PremoveSpeed = 6f;
    public float PrejumpForce = 12f;
    public float moveBuff = 0.25f;
    public float jumpBuff = 0.75f;
    public static bool buff = false;
    //int переменные:
    //bool переменные:
    public static bool died;//погиб игрок или нет
    public static bool shift; //переменна€ только дл€ мобильный версии. —в€зана с джостиком на телефоне
    private enum MovementState { idle, running, jumping, falling}
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;
    public LayerMask jumpableGround;
    public ParticleSystem dustRun;
    public ParticleSystem dustJump;
    public AudioSource jumpSoundEffect;
    private void Awake()
    {
        died = false;
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        rb.bodyType = RigidbodyType2D.Dynamic;
        moveSpeed = PremoveSpeed;
        jumpForce = PrejumpForce;
    }
    private void Update()
    {
            if (Input.GetButton("BumperL"))
            {
                jumpfull = 0.75f;
                movefull = 0.75f;
            }
            else if (Input.GetButton("BumperR"))
            {
                jumpfull = 1f;
                movefull = 1.25f;
            }
            else if (Input.GetButtonUp("BumperL") || Input.GetButtonUp("BumperR"))
            {
                jumpfull = 1f;
                movefull = 1f;
            }
            dirXcontroller = Input.GetAxisRaw(DropdownController.Cont_Horizontal);
            if (dirXcontroller > -0.25f && dirXcontroller < 0.25f)
            {
                dirXcontroller = 0f;
            }
            if (!died)
            {
                OnJump();
                Move(dirXcontroller);
                if (buff == true)
                {
                    moveSpeed += moveBuff;
                    jumpForce += jumpBuff;
                    Debug.Log("p1 Movespeed = " + moveSpeed + " and JumpForce = " + jumpForce);
                    buff = false;
                }
            }   
        UpdateAnimationUpdate();
    }
    private void Move(float v1) //Ќужна только дл€ того, что-бы можно было двигатьс€ и на клавиатуре и на контроллере одновременно. ѕринимает 2 переменных направлени€ dirX обычный и dirXController дл€ контроллера.
    {
            rb.velocity = new Vector2(v1 * moveSpeed * movefull, rb.velocity.y);
            MainDirX = v1;
    }
    public void OnJump()
    {
        if (IsGrounded() && Input.GetButtonDown(DropdownController.Cont_Up)){
            JumpVelocity(1f, "p1 jump normal");
        }
    }
    private void JumpVelocity(float jump_power, string jump_tip)
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce * jumpfull);
        Debug.Log(jump_tip);
        jumpSoundEffect.Play();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Strawberry"))
        {
            moveSpeed += moveBuff;
            jumpForce += jumpBuff;
            Debug.Log("p1 Movespeed = " + moveSpeed + " and JumpForce = " + jumpForce);
        }
    }
    private void UpdateAnimationUpdate()
    {
        MovementState state;
            if (MainDirX > 0f)
            {
                state = MovementState.running;
                sprite.flipX = false;
                CreateDustRun();
            }
            else if (MainDirX < 0f)
            {
                state = MovementState.running;
                sprite.flipX = true;
                CreateDustRun();
            }
            else
            {
                state = MovementState.idle;
                dustRun.Stop();
            }
            if (rb.velocity.y > .1f)
            {
                state = MovementState.jumping;
            }
            else if (rb.velocity.y < -.1f)
            {
                state = MovementState.falling;
            }
            anim.SetInteger("state", (int)state);
    }
    private bool IsGrounded()
    {
        bool is_ground = Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
        return is_ground;
    }
    void CreateDustRun()
    {
        dustRun.Play();
    }
    void CreateDustJump()
    {
        dustJump.Play();
    }
}
