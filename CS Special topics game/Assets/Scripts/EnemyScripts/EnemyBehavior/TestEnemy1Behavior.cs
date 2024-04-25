using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemy1Behavior : MonoBehaviour
{
    public static int enemyNumber = 0;
    public TempPlayerData tempPlayerData;
    public int hp = 1;
    public Rigidbody2D rb;
    private int moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate() {
        Vector2 moveDirection = (tempPlayerData.currentPosition - gameObject.transform.position).normalized;
        rb.MovePosition(rb.position + moveDirection*moveSpeed * Time.fixedDeltaTime);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == GameConstants.layerNameToNumber["Player Attacks"]) {
            EnemyManager.numOfEnemies -= 1;
            Destroy(gameObject);
        }
    }
}
