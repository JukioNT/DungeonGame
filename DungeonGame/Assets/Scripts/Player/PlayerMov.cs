using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{

    public int moveSpeed;

    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Animator movAnimation;
    private float directionX;
    private float directionY;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        movAnimation = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        //Mover
        directionX = Input.GetAxis("Horizontal");
        directionY = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(directionX * moveSpeed, directionY * moveSpeed);
    }

    void Update()
    {
        //Flipar
        if(rb.velocity.x < 0)
        {
            sr.flipX = true;
        }
        if(rb.velocity.x > 0)
        {
            sr.flipX = false;
        }

        //Ativar animação
        if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            movAnimation.SetBool("isRunning", true);
        }else
        {
            movAnimation.SetBool("isRunning", false);
        }
    }
}
