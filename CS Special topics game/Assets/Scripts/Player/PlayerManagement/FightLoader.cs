using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightLoader : MonoBehaviour, IDataPersistence
{
    // Start is called before the first frame update
    public string arenaToLoad;
    public int fightNum;
    public ActiveEnemyData enemySpawnData;
    public TempPlayerData fightPlayerData;
    public SaveData saveData;

    public void LoadData(SaveData data)
    {
        saveData = data;
        fightPlayerData.hp = data.maxHp;
    }

    public void SaveData(ref SaveData data)
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);
        Debug.Log(saveData.nextFightId);
        if (collision.gameObject.layer == GameConstants.layerNameToNumber["Player"] &&(saveData.nextFightId==fightNum)) {
            enemySpawnData.enemySpawnInformation = Fights.enemiesByFightId[saveData.nextFightId];
            foreach(EnemySpawnInfo ESF in enemySpawnData.enemySpawnInformation) {
                Debug.Log(ESF.toString());
            }
            SceneController.LoadScene(arenaToLoad);
            //SceneController.LoadScene(GameConstants.arenaStageNames[arenaToLoad]);
        }
    }

}
