using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowThenTp : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform tpPoint;
    private bool inCollision = false;
    private int count = 0;
    public GameObject player;
    private void Update()
    {
        if (inCollision && Input.GetMouseButtonDown(0)) {
            count++;
            print("CoffinDetec");
        }
        if(count == 2) {
            player.transform.position = tpPoint.position;
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
