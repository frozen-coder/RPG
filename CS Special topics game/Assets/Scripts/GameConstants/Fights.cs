using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fights
{
    //fight id to enemy list
    public static Dictionary<int, EnemySpawnInfo[]> enemiesByFightId = new Dictionary<int, EnemySpawnInfo[]> {
        {0, 
            new EnemySpawnInfo[] {new EnemySpawnInfo(new Vector2(5,5), "RedMan", 0),
             new EnemySpawnInfo(new Vector2(-5,-5), "RedMan", 1)} 
        },
    };
}
