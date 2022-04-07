using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoController : MonoBehaviour
{
    public float velocityX = 5;
    public float jumpForce = 100;

    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sr;

    private const int RUN = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-velocityX, rb.velocity.y);
        sr.flipX = true;
        changeAnimation(RUN);
    }
    private void changeAnimation(int animation)
    {
        animator.SetInteger("Estado", animation);
    }
}
