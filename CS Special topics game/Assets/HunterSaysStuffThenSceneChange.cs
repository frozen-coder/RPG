using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterSaysStuffThenSceneChange : MonoBehaviour
{
   public string[] lines;
    public string[] characters;
    public Dialogue dialogue;
    private bool inCollision = false;
    private int count = 0;
    private void Start() {
        dialogue.sayDialogue(lines, characters);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            count++;
            
        }
        if(count == 2) {
            SceneController.LoadScene("Fin");
        }
    }
    
}
