using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrototypeEnemySceneManager : MonoBehaviour
{
    public string s =":)";
    // Start is called before the first frame update
    public static void CustomLoadScene(string s) {
     SceneManager.LoadScene(s);
    }
}
