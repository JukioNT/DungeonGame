using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowEButton : MonoBehaviour
{

    public OpenDoor openDoor;

    private TutorialChest chest;
    private GameObject eTutorial;

    void Start()
    {
        chest = Object.FindObjectOfType<TutorialChest>();
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
        if(chest.isOpend)
        {
            openDoor.DoorOpen();
        }
    }
}
