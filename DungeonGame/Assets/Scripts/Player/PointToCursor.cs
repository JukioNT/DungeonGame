using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToCursor : MonoBehaviour
{
    void FixedUpdate()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        mousePos.Normalize();

        float rotationz = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, rotationz-90);
    }
}
