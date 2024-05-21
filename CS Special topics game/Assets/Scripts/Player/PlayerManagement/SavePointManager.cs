using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePointManager : MonoBehaviour, IDataPersistence
{
    private bool isOccupied = false;
    public int savePoint;
    public SaveData saveData;
    // Update is called once per frame
    void Update()
    {
        //TODO: Make this pull up the save dialog box or smmth
        if (Input.GetKeyDown(KeyCode.Mouse0) && isOccupied) {
            saveData.currentSavePoint = savePoint;
            Debug.Log("New Save Point = " +  savePoint);
            DataPersistenceManager.SaveCurrentData();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision);
        
        if (collision.gameObject.layer == GameConstants.layerNameToNumber["Player"]) {
            isOccupied = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log(collision);

        if (collision.gameObject.layer == GameConstants.layerNameToNumber["Player"])
        {
            isOccupied = false;
        }
    }

    public void LoadData(SaveData data)
    {
        saveData = data;
    }

    public void SaveData(ref SaveData data)
    {
        data = saveData;
    }
}
