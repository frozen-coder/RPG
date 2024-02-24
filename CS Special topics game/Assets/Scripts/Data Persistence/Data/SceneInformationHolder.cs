using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class SceneInformationHolder 
{
    public string SceneName;
    public int SavePoint;
    public SceneInformationHolder() {
        SceneName = GameConstants.overworldStageNames["StageOne"];
        SavePoint = 0;
    }
}
