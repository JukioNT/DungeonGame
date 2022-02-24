using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestDropItems : MonoBehaviour
{

    private OpenChest chest;
    private float chestPosX;
    private float chestPosY;

    //GameItems
    private GameObject smallHPotion;

    void Start()
    {
        chest = gameObject.GetComponent<OpenChest>();
        chestPosX = chest.GetComponent<Transform>().position.x;
        chestPosY = chest.GetComponent<Transform>().position.y;
        GetItems();
    }

    void Update()
    {
        if (Input.GetKeyDown("e") && chest.colPlayer == true)
        {
            Instantiate(smallHPotion, new Vector3(chestPosX, chestPosY-1, 0), Quaternion.identity);
        }
    }

    void GetItems()
    {
        smallHPotion = GameObject.Find("SmallHealthPotion");
    }
}
