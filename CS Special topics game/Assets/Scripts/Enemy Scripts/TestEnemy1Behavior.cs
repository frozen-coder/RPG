using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemy1Behavior : MonoBehaviour
{
    public TempPlayerData tempPlayerData;
    public int hp = 1;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.layer == GameConstants.layerNameToNumber["Enemy Attacks"]) {
            Destroy(gameObject);
        }
    }
}
