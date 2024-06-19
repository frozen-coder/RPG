using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffinFireSpawn : MonoBehaviour
{
    public SpriteRenderer coffin;
    public Sprite coffinOnFire;
    private bool inCollision = false;
    private int count = 0;
    private void Update()
    {
        if (inCollision && Input.GetMouseButtonDown(0)) {
            count++;
            print("CoffinDetec");
        }
        if(count == 2) {
            coffin.sprite = coffinOnFire;
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
