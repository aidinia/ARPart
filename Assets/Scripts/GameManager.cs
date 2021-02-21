using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private List<Dictionary<string, List<string>>> levels;

    // Start is called before the first frame update
    void Start()
    {
        var thisPlayer = PhotonNetwork.Instantiate("AR Camera", Vector3.zero, Quaternion.identity);

        LoadLevels(thisPlayer);
      //  text.text = "Player initiated";

    }

    public List<string> GetLevelsItems(List<Dictionary<string, List<string>>> levels)
    {
        var items = new List<string>();

       // GameObject.Find("DebugText").GetComponent<TextMesh>().text = "getting Items" + levels.ToString();

        foreach (var lvlDetail in levels)
        {
            var itemsInLevel = lvlDetail["items"];

            foreach (var item in itemsInLevel)
            {
                items.Add(item);
            }
        }

        return items;
    }

    public void LoadLevels(GameObject player)
    {

        levels = Levels.GetLevels();

        var items = GetLevelsItems(levels);
        GameObject.Find("DebugText").GetComponent<TextMesh>().text = "Load  -";

        var index = 0;
        foreach(var obj in items)
        {
            GameObject.Find("DebugText").GetComponent<TextMesh>().text =  obj;

            var x = Random.Range(0, 4);
            var y = Random.Range(0, 2);
            var z = Random.Range(0, 4);
            Vector3 position = player.transform.position;
            Vector3 itemposition = position + new Vector3(x, y, z);

           var item =  PhotonNetwork.Instantiate(obj, itemposition, Quaternion.identity);

            GameObject.Find("DebugText").GetComponent<TextMesh>().text = item.name;
            index++;
            GameObject.Find("DebugText").GetComponent<TextMesh>().text = index.ToString();

        }

    }
}
