using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightLoadekr : MonoBehaviour
{
    // Start is called before the first frame update
    public string arenaToLoad;
    public int fightNum;
    public ActiveEnemyData enemySpawnData;
    public SaveData saveData;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);
        
        if (collision.gameObject.layer == GameConstants.layerNameToNumber["Player"] &&(saveData.nextFightId==fightNum)) {
            enemySpawnData.enemySpawnInformation = Fights.enemiesByFightId[0];
            foreach(EnemySpawnInfo ESF in enemySpawnData.enemySpawnInformation) {
                Debug.Log(ESF.toString());
            }
            SceneController.LoadScene(arenaToLoad);
            //SceneController.LoadScene(GameConstants.arenaStageNames[arenaToLoad]);
        }
    }
}
