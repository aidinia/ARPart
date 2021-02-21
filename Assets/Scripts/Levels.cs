using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    
    public static List<List<Dictionary<string, List<string>>>> AllLevels = new List<List<Dictionary<string, List<string>>>> {
        // Levels 1
        new List<Dictionary<string, List<string>>> {
            new Dictionary<string, List<string>>
            {
                {"items",new List<string>{"Heart", "Apple","Light"} }
            }
        },

        // Levels 2
        new List<Dictionary<string, List<string>>>(),

        // Levels 3
        new List<Dictionary<string, List<string>>>()
    
};


    public static List<Dictionary<string, List<string>>> GetLevels()
    {

        var game = new List<Dictionary<string, List<string>>>();
       // var random = Random.Range(0, AllLevels[0].Count);
        game.Add(AllLevels[0][0]);
       
        return game;
    }

}
