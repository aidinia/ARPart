using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerIcon : MonoBehaviour
{
    Object[] guids2;
    public GameObject playerIcon;
    public Text text;
    int index = 0;
    bool touching = false;

    void Awake()
    {
        // Load icons
        guids2 = Resources.LoadAll("ARISAN/100 Alchemy item icons-free", typeof(Sprite));
    }

 
    public void changeIcon()
    {
        index++;

        if (index == guids2.Length)
        {
            index = 0;
        }
        var icon = guids2[index];
        playerIcon.GetComponent<Image>().sprite = (Sprite)icon;
    }
}
