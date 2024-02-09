using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DataPersistenceManager : MonoBehaviour
{
    private GameData gameData;
    public static DataPersistenceManager instance { get; private set; }
    
    private List<IDataPersistence> dataPersistenceObjects;
    private void Awake()
    {
        if (instance != null) {
            Debug.LogError("Found more than one Data Persistence Manager in the scene.");
        }
        instance = this;
    }
    private void Start()
    {
        this.dataPersistenceObjects = FindAllDataPersistenceObjects();
        LoadGame();   
    }

    public void NewGame() { 
        this.gameData = new GameData();
    }
    public void LoadGame() { 
        //TODO - load any saved data from a file using the data handler
        // if no data can be loaded, initialize to a new game
        if (this.gameData == null) {
            Debug.Log("No data was found. Initializing data to defaults");
            NewGame();
        }
        // TODO - push the loaded data to all other scripts tha need it
        foreach(IDataPersistence dataPersistenceObj in dataPersistenceObjects) {
            dataPersistenceObj.LoadData(gameData);
        }

        Debug.Log("Loaded position = " + gameData.position);

    }
    public void SaveGame()
    {
        // TODO - pass the data to other scripts so they can update it
        foreach (IDataPersistence dataPersistenceObj in dataPersistenceObjects) {
           dataPersistenceObj.SaveData(ref gameData);
        }
        // TODO  - save that data to a file using the data handler
        Debug.Log("Position = " + gameData.position);
    }
    
    private void OnApplicationQuit() {
        SaveGame();
    }

    private List<IDataPersistence> FindAllDataPersistenceObjects()
    {
        IEnemerable<IDataPersistence> dataPersistenceObjects = FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistence>();

        return new List<IDataPersistence>(dataPersistenceObjects);
    }
}
