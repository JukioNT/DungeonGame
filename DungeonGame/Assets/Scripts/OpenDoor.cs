using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    public Sprite upDoorOpend;
    public Sprite downDoorOpend;

    public GameObject doorUp;
    public GameObject doorDown;

    void DoorOpen()
    {
        doorUp.GetComponent<SpriteRenderer>().sprite = upDoorOpend;
        doorUp.GetComponent<SpriteRenderer>().sortingOrder = 6;
        doorUp.GetComponent<BoxCollider2D>().enabled = false;
        doorUp.GetComponent<EdgeCollider2D>().enabled = true;
        doorDown.GetComponent<SpriteRenderer>().sprite = downDoorOpend;
        doorDown.GetComponent<EdgeCollider2D>().enabled = true;
    }
}
