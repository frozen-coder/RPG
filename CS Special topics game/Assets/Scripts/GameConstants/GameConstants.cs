using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
 
public static class GameConstants 
{
    public static Dictionary<string, string> overworldStageNames = new Dictionary<string, string>
    {
        {"StageOne", "StageOneOverworld"},
    };
    public static Dictionary<string, string> arenaStageNames = new Dictionary<string, string> {
        {"StageOne", "StageOneOutdoorFightArena"},
    };
    public static Dictionary<string, int> layerNameToNumber  = new Dictionary<string, int> {
        {"Default", 0},
        {"TransparentFX", 1},
        {"Ignore Raycast", 2},
        {"Enemy Attacks", 3 },
        {"Water", 4 },
        {"UI", 5 },
        {"Player", 6 },
        {"Wall", 7 },
        {"Enemies", 8 },
        {"Invulnerable", 9 },
        {"Player Attacks", 10 },
        {"Trigger", 11},
    };
    //path from the recources fol.der
    public static Dictionary<string, string> enemyTypeToPath = new Dictionary<string, string> {
        {"TestEnemy1", "Prefabs/EnemyPrefabs/TestEnemy1"},
        //{"Wolf", "Prefabs/EnemyPrefabs/Wolf}
    };
    public static Dictionary<string, string> projectileTypeToPath = new Dictionary<string, string> {
        {"BasicPlayerArrow", "Prefabs/AttackPrefabs/BasicPlayerArrow"},
    };
    
}
