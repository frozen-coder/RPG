using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour, IDataPersistence
{
    // Start is called before the first frame update
    private static string currScene;
    private static int currentSavePoint;
    public static void LoadCurrScene()
    {
        Debug.Log("Loading: " + currScene);
        SceneManager.LoadScene(currScene);
    }
    public static void LoadScene(string sceneName) {
        Debug.Log("Loading: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
    public void LoadData(SaveData data)
    {
        currScene = data.currScene;
    }

    public void SaveData(ref SaveData data)
    {
        data.currScene = currScene;
    }
}
 