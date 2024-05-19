using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadCurrentSavedScene : MonoBehaviour, IDataPersistence
{
    private string sceneToLoad;
    public Button startButton;
    public void LoadData(SaveData data)
    {
        sceneToLoad = data.currentOverworldScene;
    }

    public void SaveData(ref SaveData data)
    {

    }
    void Start() {
        Button btn = startButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadScene);
    }

    public void LoadScene()
    {
        SceneController.LoadScene(sceneToLoad);
    }
}
