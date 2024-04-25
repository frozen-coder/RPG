using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fights
{
    //fight id to enemy list
    //format
    //fight id to
    // Enemy spawn info array of enemy Spawn Info
    // Enemy Spawn info has vector 2 of position as well as the enemy Name
    //using vector 3 b/c intantiate only takes vector 3s
    public static Dictionary<int, EnemySpawnInfo[]> enemiesByFightId = new Dictionary<int, EnemySpawnInfo[]> {
        {0, 
            new EnemySpawnInfo[] {new EnemySpawnInfo(new Vector3(5,5,0), "TestEnemy1", 0),
             new EnemySpawnInfo(new Vector3(-5,-5,0), "TestEnemy1", 1)} 
        },
    };
}
