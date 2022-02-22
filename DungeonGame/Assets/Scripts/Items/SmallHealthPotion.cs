using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallHealthPotion : MonoBehaviour
{

    public int itemID;
    public int healthHeal;
    private int healthLeft;
    private bool canDestroy;

    private PlayerHealth pH;

    void Start()
    {
        pH = GameObject.FindGameObjectWithTag("player").GetComponent<PlayerHealth>();
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        healthLeft = pH.maxHealth - pH.health;
        if(healthLeft >= healthHeal)
        {
            pH.GetLife(healthHeal);
            canDestroy = true;
        }else if(healthLeft < healthHeal)
        {
            pH.GetLife(pH.maxHealth - pH.health);
            canDestroy = true;
        }else
        {
            canDestroy = false;
        }
        if (other.gameObject.tag == "player")
        {
            if (canDestroy == true)
            {
                Destroy(gameObject);
            }
        }
    }
}
