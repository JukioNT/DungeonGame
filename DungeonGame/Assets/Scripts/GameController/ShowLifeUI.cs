using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ShowLifeUI : MonoBehaviour
{

    public Image[] lifeImages;
    public Sprite[] lifeSprites;

    [HideInInspector]
    public int heartSelected;
    [HideInInspector]
    public int heartLife;

    void Start()
    {
        heartSelected = 0;
        heartLife = 0;
    }

    void Update()
    {
        ShowHearts();
    }

    public void ShowHearts()
    {
        if(heartLife == 3)
        {
            heartSelected += 1;
            heartLife = 1;
        }
        if(heartLife == -1)
        {
            heartSelected -= 1;
            heartLife = 1;
            CureHafHeart();
        }
        lifeImages[heartSelected].GetComponent<Image>().sprite = lifeSprites[heartLife];
    }
    public void CureHafHeart()
    {
        lifeImages[heartSelected+1].GetComponent<Image>().sprite = lifeSprites[0];
    }
}
