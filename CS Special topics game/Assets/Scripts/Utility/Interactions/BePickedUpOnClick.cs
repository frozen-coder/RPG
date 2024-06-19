using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BePickedUpOnClick : MonoBehaviour
{
    private bool inCollision = false;
    private bool followPlayer = false;
    public TempPlayerData tempPlayerData;
    private void Update()
    {
        if (inCollision && Input.GetMouseButtonDown(0)) {
            gameObject.SetActive(false);
        }
        if(followPlayer) {
            Vector3 pos = new Vector3(tempPlayerData.currentPosition.x + 15, tempPlayerData.currentPosition.y+15, tempPlayerData.currentPosition.z);
            gameObject.transform.position = tempPlayerData.currentPosition;
        }
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == GameConstants.layerNameToNumber["Player"] || collision.gameObject.layer == GameConstants.layerNameToNumber["Invulnerable"] )
        {
            print("Wood!");
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
