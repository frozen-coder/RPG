using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviorPrototype : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
        
    public ProjectileLeadingBehaviorPrototype projectilePrefab;
    public Rigidbody2D playerRb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rb.velocity.x);
        Debug.Log(rb.velocity.y);
        CustomMathFuncsPrototype.caculateAngleToLead(playerRb.velocity, playerRb.position, rb.position, 10);
    }
    void OnCollisionEnter2D(Collision2D collision) {
        //if(collision.Parrent 0)
    }
}
