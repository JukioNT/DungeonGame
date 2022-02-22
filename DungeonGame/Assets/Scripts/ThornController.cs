using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThornController : MonoBehaviour
{

    private PlayerHealth pH;

    public Sprite[] thornsSprites;
    private int spriteSelector;

    private float time;
    private float timeDelay;

    void Start()
    {
        pH = GameObject.FindGameObjectWithTag("player").GetComponent<PlayerHealth>();
        time = 0f;
        timeDelay = 1f;
    }

    void Update()
    {
        time = time + 1f * Time.deltaTime;
        if(time >= timeDelay)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = thornsSprites[spriteSelector];

            spriteSelector += 1;
            if(spriteSelector == 4)
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = true;
                spriteSelector = 0;
            }else
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
            }
            time = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "player")
        {
            pH.TakeDamage();
        }
    }
}
