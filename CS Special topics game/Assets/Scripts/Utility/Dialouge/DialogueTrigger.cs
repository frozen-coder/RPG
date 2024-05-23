using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    
    public string[] lines;
    public string[] characters;
    public Dialogue dialogue;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.layer == GameConstants.layerNameToNumber["Player"] || collision.gameObject.layer == GameConstants.layerNameToNumber["Invulnerable"] ) && Input.GetMouseButtonDown(0));
        {
            print("LOLA!");
            dialogue.sayDialogue(lines, characters);
        }
    }
}
