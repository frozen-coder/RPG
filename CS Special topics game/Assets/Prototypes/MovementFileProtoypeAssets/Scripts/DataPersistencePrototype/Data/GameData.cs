using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class GameData {
    
   public Vector2 position;

    // the values defined in this constructor will be the default values
    // the game starts with them when there's no data to load
    public GameData() { 
        position = Vector2.zero;
    }
}
