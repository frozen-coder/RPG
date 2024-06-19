using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerSpawnManager : MonoBehaviour, IDataPersistence
{
    //public Transform player;
    public Transform[] spawnLocations;
    private string scene;
    private int savePoint;
    public TempPlayerData tempPlayerData;
    public SaveData saveData;
    public GameObject OverworldPlayer;
    public bool startSelf;
    // Start is called before the first frame update
    /*
    void Start()
    {
        //Debug.Log(sceneInfoHolder.SceneName);
        //player.position = spawnLocations[sceneInfoHolder.SavePoint].position;
        //tempPlayerData.currentPosition = player.position;
    }
    */
    public void SpawnPlayer() {
        OverworldPlayer.transform.position = tempPlayerData.currentPosition;   
        print(OverworldPlayer.transform.position);
        OverworldPlayer.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadData(SaveData data)
    {
        scene = data.currentOverworldScene;
        savePoint = data.currentSavePoint;
        tempPlayerData.currentPosition = spawnLocations[savePoint].position;
        print(spawnLocations[savePoint].position);
        print(tempPlayerData.currentPosition);
        if(startSelf) {
            SpawnPlayer();
        }
        
    }

    public void SaveData(ref SaveData data)
    {
        //data.position = this.rb.position;
    }
}
