using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour, IDataPersistence
{
    // Start is called before the first frame update
    private static SceneInformationHolder currScene;
    public static void LoadCurrScene()
    {
        Debug.Log("Loading: " + currScene.SceneName);
        SceneManager.LoadScene(currScene.SceneName);
    }
    public static void LoadScene(string sceneName) {
        Debug.Log("Loading: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
    public void LoadData(GameData data)
    {
        currScene = data.currScene;
    }

    public void SaveData(ref GameData data)
    {
        data.currScene = currScene;
    }
}
 