using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBow : MonoBehaviour
{
    
    public PlayerAttackManager attack;
    private bool inCollision = false;
    private void Update()
    {
        if (inCollision) {
            attack.active = true;
            gameObject.SetActive(false);
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
