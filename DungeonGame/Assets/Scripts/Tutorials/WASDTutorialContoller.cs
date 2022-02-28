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
        if(Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.UpArrow))
        {
            wCondition = true;
        }
        if (Input.GetKeyDown("a") || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            aCondition = true;
        }
        if (Input.GetKeyDown("s") || Input.GetKeyDown(KeyCode.DownArrow))
        {
            sCondition = true;
        }
        if (Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.RightArrow))
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
