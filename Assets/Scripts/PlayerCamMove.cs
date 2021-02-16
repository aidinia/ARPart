using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCamMove : MonoBehaviourPun
{

    private TextMesh text;

    private void Start()
    {
        text = GameObject.Find("DebugText").GetComponent<TextMesh>();
    }
    private void Update()
    {
        if (photonView.IsMine)
        {
           // text.text = this.transform.position.ToString();
        }
    }
}
