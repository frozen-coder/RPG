using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerDataManager : MonoBehaviour, IDataPersistence
{
    public SaveData saveData;
    public void LoadData(GameData data) {
        saveData.currentSaveScene = data.currScene.SceneName;
        saveData.currentSavePoint = data.currScene.SavePoint;
    }
    public void SaveData(ref GameData data)
    {
        data.currScene.SceneName = saveData.currentSaveScene;
        data.currScene.SavePoint = saveData.currentSavePoint;
    }
}
