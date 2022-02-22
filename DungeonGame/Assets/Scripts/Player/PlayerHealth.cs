using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth;
    public int health;

    private int randXY;
    private int randPN;
    private Rigidbody2D playerRB;

    private ShowLifeUI lifeUI;

    private void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        lifeUI = GameObject.FindGameObjectWithTag("GameController").GetComponent<ShowLifeUI>();
    }

    public void GetLife(int life)
    {
        health = health + life;
        lifeUI.heartLife -= life;
    }

    public void TakeDamage()
    {
        health -= 1;
        lifeUI.heartLife += 1;
        DamageThrow(10);
    }
    public void DamageThrow(int throwForce)
    {
        
    }
}
