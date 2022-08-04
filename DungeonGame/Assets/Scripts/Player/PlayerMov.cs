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
    private GameObject weapon;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        movAnimation = GetComponent<Animator>();
        weapon = transform.GetChild(0).gameObject;
    }

    void Update()
    {
        if (Input.GetKeyDown("a") || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            sr.flipX = true;
            weapon.GetComponent<SpriteRenderer>().flipX = true;
            weapon.transform.position = new Vector3(gameObject.transform.position.x - 0.3f, gameObject.transform.position.y - 0.55f, gameObject.transform.position.z);
        }
        if (Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.RightArrow))
        {
            sr.flipX = false;
            weapon.GetComponent<SpriteRenderer>().flipX = false;
            weapon.transform.position = new Vector3(gameObject.transform.position.x + 0.3f, gameObject.transform.position.y - 0.55f, gameObject.transform.position.z);
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
