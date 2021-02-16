using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        var thisPlayer = PhotonNetwork.Instantiate("AR Camera", Vector3.zero,Quaternion.identity);
        LoadLevels(thisPlayer);
      //  text.text = "Player initiated";

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevels(GameObject player)
    {
        var heart = PhotonNetwork.Instantiate("Heart0", player.transform.position, player.transform.rotation);
        var ball = PhotonNetwork.Instantiate("Sphere000", player.transform.position + Vector3.one, player.transform.rotation);

    }
}
