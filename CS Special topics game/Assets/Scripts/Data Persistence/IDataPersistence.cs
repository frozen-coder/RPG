using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataPersistence
{
    // LoadData sends data out to classes that need it
    void LoadData(SaveData data);
    //SaveData loads current Data
    void SaveData(ref SaveData data);

}
