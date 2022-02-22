using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{

    public Sprite chestOpend;
    private bool colPlayer;
    private SpriteRenderer spriteR;

    void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(Input.GetKeyDown("e") && colPlayer == true)
        {
            Animation();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "player")
        {
            colPlayer = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "player")
        {
            colPlayer = false;
        }
    }

    void Animation()
    {
        spriteR.sprite = chestOpend;
    }
}
