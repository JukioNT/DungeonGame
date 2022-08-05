using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToCursor : MonoBehaviour
{

    private PlayerMov flip;
    private GameObject player;

    void Start()
    {
        flip = Object.FindObjectOfType<PlayerMov>();
        player = GameObject.Find("Player");
    }

    void FixedUpdate()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        mousePos.Normalize();
        float rotationz = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotationz-90);

        Vector3 mousePosPlayer = Camera.main.ScreenToWorldPoint(Input.mousePosition) - player.transform.position;

        if (mousePosPlayer.x > 0)
        {
            flip.FlipPlayer(true);
        }
        else
        {
            flip.FlipPlayer(false);
        }
    }
}
