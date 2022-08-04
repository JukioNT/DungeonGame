using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchItem : MonoBehaviour
{

    private BoxCollider2D bc;
    private GameObject gSprite;

    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
        gSprite = transform.GetChild(0).gameObject;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Gun")
        {
            Destroy(other.gameObject);
            gSprite.GetComponent<SpriteRenderer>().sprite = other.GetComponent<SpriteRenderer>().sprite;
        }
    }
}
