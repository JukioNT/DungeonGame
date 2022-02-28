using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{

    public float moveSpeed;

    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Animator movAnimation;
    private float directionX;
    private float directionY;
    private Vector2 directionMov;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        movAnimation = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown("a") || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            sr.flipX = true;
        }
        if (Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.RightArrow))
        {
            sr.flipX = false;
        }

        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            movAnimation.SetBool("isRunning", true);
        }
        else
        {
            movAnimation.SetBool("isRunning", false);
        }

        directionX = Input.GetAxisRaw("Horizontal");
        directionY = Input.GetAxisRaw("Vertical");
        directionMov = new Vector2(directionX, directionY);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(directionMov.x * moveSpeed, directionMov.y * moveSpeed);
    }
}
