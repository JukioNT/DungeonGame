using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowEButton : MonoBehaviour
{

    private OpenChest chest;
    private GameObject eTutorial;

    void Start()
    {
        chest = Object.FindObjectOfType<OpenChest>();
        eTutorial = GameObject.FindGameObjectWithTag("ETutorial");
    }

    void Update()
    {
        if(chest.colPlayer && !chest.isOpend)
        {
            eTutorial.SetActive(true);
        }else
        {
            eTutorial.SetActive(false);
        }
    }
}
