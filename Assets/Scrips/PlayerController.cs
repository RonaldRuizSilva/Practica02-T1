using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocityX = 5;
    public float jumpForce = 100;

    // Start is called before the first frame update

    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sr;

    //constantes

    
    private const int RUN = 1;
    private const int SLIDE = 2;
    private const int JUMP = 3;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity = new Vector2(velocityX, rb.velocity.y);
        sr.flipX = false;
        changeAnimation(RUN);

    
        if (Input.GetKey(KeyCode.X))
        {
            changeAnimation(SLIDE);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            changeAnimation(JUMP);
        }
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("obstaculo"))
        {
            sr.flipX = !sr.flipX;
            velocityX = velocityX * -1;
        }
    }*/


    private void changeAnimation(int animation)
    {
        animator.SetInteger("Estado", animation);
    }
}