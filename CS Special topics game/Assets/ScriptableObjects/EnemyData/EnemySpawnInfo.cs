using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnInfo
{
    public Vector3 position;
    public string enemyType;
    public int id;
    public EnemySpawnInfo(Vector2 positionIn, string enemyTypeIn, int idIn) {
        position = positionIn;
        enemyType = enemyTypeIn;
        id = idIn;
    }
    public string toString() {
        return("Position: " + position + " Enemy Type: " + enemyType + " Id: " + id);
    }

}
