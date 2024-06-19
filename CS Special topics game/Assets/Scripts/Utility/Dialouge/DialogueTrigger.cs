using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    
    public string[] lines;
    public string[] characters;
    public Dialogue dialogue;
    private bool inCollision = false;
    private void Update()
    {
        if (inCollision && Input.GetMouseButtonDown(0) && ! Dialogue.dialogActive) {
            print("ACTIVATEBB");
            dialogue.sayDialogue(lines, characters);
        }
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == GameConstants.layerNameToNumber["Player"] || collision.gameObject.layer == GameConstants.layerNameToNumber["Invulnerable"] )
        {
            print("LOLA!");
            inCollision = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == GameConstants.layerNameToNumber["Player"] || collision.gameObject.layer == GameConstants.layerNameToNumber["Invulnerable"]) {
            print("ADIOS BIITIAH");
            inCollision = false;
        }
    }
}
