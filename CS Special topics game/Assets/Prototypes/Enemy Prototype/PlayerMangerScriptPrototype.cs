using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerMangerScriptPrototype
{
    public static void playerHit() {
        EnemyGameDataPrototype.Lives -= 1;
        if (EnemyGameDataPrototype.Lives <= 0) {
            PrototypeEnemySceneManager.CustomLoadScene("DeathPrototype");
        }
    }
}
