using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLive : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] private AudioSource deathSoundEffect;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!DropDownImmortal.immortal)
        {
            if (collision.gameObject.CompareTag("Trap"))
            {
                Die();
                DieSound();
            }
        }
            
    }
    private void Update()
    {
        if (LevelLoader.isAnimDeadPlayed)
        {
            RestartLevel();
        }
        if (Input.GetKey("r"))
        {
            Die();
            DieSound();
        }
    }

    public void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
        ItemCollector.allstrawberries -= ItemCollector.strawberries;
        PlayerMovement.died = true;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void DieSound()
    {
        deathSoundEffect.Play();
    }
}
