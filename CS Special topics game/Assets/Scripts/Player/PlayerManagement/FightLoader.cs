using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightLoader : MonoBehaviour, IDataPersistence
{
    // Start is called before the first frame update
    public string arenaToLoad;
    public int fightNum;
    public ActiveEnemyData enemySpawnData;
    public SaveData saveData;

    public void LoadData(SaveData data)
    {
        saveData = data;
    }

    public void SaveData(ref SaveData data)
    {
        
    }

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
