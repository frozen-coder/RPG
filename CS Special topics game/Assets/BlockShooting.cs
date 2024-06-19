using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockShooting : MonoBehaviour
{
    private bool inCollision = false;
    public PlayerAttackManager attackManager;
    private int count = 0;
    private void Update()
    {
        if (inCollision&& Input.GetMouseButtonDown(0) && count == 0) {
            count++;
            attackManager.active = false;
        }
        else if(Input.GetMouseButtonDown(0) && inCollision && count < 3) {
            count++;
        }
        else if(count >= 3){
            attackManager.active = true;
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
