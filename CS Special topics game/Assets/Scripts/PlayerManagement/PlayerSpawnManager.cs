using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerSpawnManager : MonoBehaviour, IDataPersistence
{
    //public Transform player;
    public Transform[] spawnLocations;
    private SceneInformationHolder sceneInfoHolder;
    public TempPlayerData tempPlayerData;
    public SaveData saveData;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(sceneInfoHolder.SceneName);
        //player.position = spawnLocations[sceneInfoHolder.SavePoint].position;
        //tempPlayerData.currentPosition = player.position;
        tempPlayerData.currentPosition = spawnLocations[sceneInfoHolder.SavePoint].position;
        Debug.Log( tempPlayerData.currentPosition);
        saveData.currentSavePoint = sceneInfoHolder.SavePoint;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadData(GameData data)
    {
        this.sceneInfoHolder = data.currScene;

    }

    public void SaveData(ref GameData data)
    {
        //data.position = this.rb.position;
    }
}
