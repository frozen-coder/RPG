using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePointMangager : MonoBehaviour
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
}
