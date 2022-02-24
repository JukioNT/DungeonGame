using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestDropItems : MonoBehaviour
{

    private OpenChest chest;

    void Start()
    {
        chest = gameObject.GetComponent<OpenChest>();
    }

    void Update()
    {
        if (Input.GetKeyDown("e") && chest.colPlayer == true)
        {
            
        }
    }
}
