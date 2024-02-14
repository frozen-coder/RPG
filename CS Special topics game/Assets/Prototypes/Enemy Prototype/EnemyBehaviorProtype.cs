using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviorPrototype : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
        
    public ProjectileLeadingBehaviorPrototype projectilePrefab;
    public ExclamationMarkBehavior exclamationMark;
    private Rigidbody2D playerRb;
    private float time = 0;
    private Boolean attacking = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerRb = EnemyGameDataPrototype.player;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rb.velocity.x);
        Debug.Log(rb.velocity.y);
        Debug.Log("Angle to pew pew = " + CustomMathFuncsPrototype.caculateAngleToLead(playerRb.velocity, playerRb.position, rb.position, 10));
    }
    private void FixedUpdate()
    {
        if(attacking ==  false)
        {
            if (time == 0) {
               ExclamationMarkBehavior childGameObject = Instantiate(exclamationMark, gameObject.transform);
                childGameObject.name = "InstantiateChild";
                attacking = true;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision) {
        //if(collision.Parrent 0)
    }
}
