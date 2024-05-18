using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerDataManager : MonoBehaviour, IDataPersistence
{
    public SaveData saveData;
    public GameObject player;
    public void LoadData(SaveData data) {
        saveData.currentSaveScene = data.currScene.SceneName;
        saveData.currentSavePoint = data.currScene.SavePoint;
        saveData.nextFightId = data.fightId;
        player.SetActive(true);
    }
    public void SaveData(ref SaveData data)
    {
        data.currScene.SceneName = saveData.currentSaveScene;
        data.currScene.SavePoint = saveData.currentSavePoint;
        data.fightId = saveData.nextFightId;
    }
}
