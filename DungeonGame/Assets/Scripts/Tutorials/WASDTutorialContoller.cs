using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDTutorialContoller : MonoBehaviour
{

    private GameObject tutorial;
    public OpenDoor openDoor;

    private bool wCondition = false;
    private bool aCondition = false;
    private bool sCondition = false;
    private bool dCondition = false;

    void Start()
    {
        tutorial = GameObject.FindGameObjectWithTag("WASDTutorial");
    }

    void Update()
    {
        if(Input.GetKeyDown("w"))
        {
            wCondition = true;
        }
        if (Input.GetKeyDown("a"))
        {
            aCondition = true;
        }
        if (Input.GetKeyDown("s"))
        {
            sCondition = true;
        }
        if (Input.GetKeyDown("d"))
        {
            dCondition = true;
        }
        if(wCondition && aCondition && sCondition && dCondition)
        {
            openDoor.DoorOpen();
            Destroy(tutorial);
        }
    }
}
