using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IvisibleDamage : MonoBehaviour
{

    private PlayerHealth player;
    private bool canTakeDamage;

    void Start()
    {
        player = Object.FindObjectOfType<PlayerHealth>();
        canTakeDamage = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player" && canTakeDamage)
        {
            player.TakeDamage(5);
            canTakeDamage = false;
        }
    }
}
