using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DataPersistenceManager : MonoBehaviour
{
    [Header("File Storage Config")]

    [SerializeField] private string fileName;

    private SaveData gameData;

    public static DataPersistenceManager instance { get; private set; }
    
    private List<IDataPersistence> dataPersistenceObjects;

    private FileDataHandler dataHandler;
    private void Awake()
    {
        if (instance != null) {
            Debug.LogError("Found more than one Data Persistence Manager in the scene.");
        }
        instance = this;
        this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName);
        this.dataPersistenceObjects = FindAllDataPersistenceObjects();
        LoadGame();
    }
    private void Start()
    {
        
    }

    public void NewGame() { 
        this.gameData = new SaveData();
    }
    public void LoadGame() {
        //TODO - load any saved data from a file using the data handler
        // if no data can be loaded, initialize to a new game
        this.gameData = dataHandler.Load();
        if (this.gameData == null) {
            Debug.Log("No data was found. Initializing data to defaults");
            NewGame();
        }
        // TODO - push the loaded data to all other scripts tha need it
        foreach(IDataPersistence dataPersistenceObj in dataPersistenceObjects) {
            dataPersistenceObj.LoadData(gameData);
        }

        Debug.Log("CurrentScene = " + gameData.currScene.SceneName);
        Debug.Log("CurrentSavePoint = " + gameData.currScene.SavePoint);

    }
    public void SaveGame()
    {
        // TODO - pass the data to other scripts so they can update it
        foreach (IDataPersistence dataPersistenceObj in dataPersistenceObjects) {
           dataPersistenceObj.SaveData(ref gameData);
        }
        // TODO  - save that data to a file using the data handler

        dataHandler.Save(gameData);
    }
    
    private void OnApplicationQuit() {
        SaveGame();
    }
    public static void SaveCurrentData() {
        instance.SaveGame();
    }

    private List<IDataPersistence> FindAllDataPersistenceObjects()
    {
        IEnumerable<IDataPersistence> dataPersistenceObjects = FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistence>();

        return new List<IDataPersistence>(dataPersistenceObjects);
    }
}
