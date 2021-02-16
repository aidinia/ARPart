using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public TextMesh text;

    // Start is called before the first frame update
    void Start()
    {
        var thisPlayer = PhotonNetwork.Instantiate("AR Camera", Vector3.zero,Quaternion.identity);
        text.text = "Player initiated";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
