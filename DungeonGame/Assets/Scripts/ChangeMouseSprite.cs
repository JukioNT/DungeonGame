using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMouseSprite : MonoBehaviour
{

    public Texture2D mouseSprite;

    void Start()
    {
        Cursor.SetCursor(mouseSprite, Vector2.zero, CursorMode.Auto);
    }

    void Update()
    {
        
    }
}
