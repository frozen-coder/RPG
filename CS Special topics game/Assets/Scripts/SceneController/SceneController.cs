using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadCurrScene()
    {
        Debug.Log("Change Scene Sesame");
        SceneManager.LoadScene("PrototypeEnemy");
    }

}
 