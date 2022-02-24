using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigHealthPotion : MonoBehaviour
{
    public int itemID;
    public int healthHeal;
    private bool canDestroy;

    private PlayerHealth ph;

    void Start()
    {
        ph = Object.FindObjectOfType<PlayerHealth>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (ph.health != ph.maxHealth)
        {
            ph.GetLife(healthHeal);
            canDestroy = true;
        }
        else
        {
            canDestroy = false;
        }
        if (other.gameObject.tag == "Player")
        {
            if (canDestroy == true)
            {
                Destroy(gameObject);
            }
        }
    }
}
