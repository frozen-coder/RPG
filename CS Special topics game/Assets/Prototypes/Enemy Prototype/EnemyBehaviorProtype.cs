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
        //Debug.Log(rb.velocity.x);
        //Debug.Log(rb.velocity.y);
        //Debug.Log("Angle to pew pew = " + CustomMathFuncsPrototype.caculateAngleToLead(playerRb.velocity, playerRb.position, rb.position, 10));
    }
    private void FixedUpdate()
    {
        time += Time.deltaTime;
        if(attacking ==  false)
        {
            if (time >5) {
               Debug.Log("HALOO");
              
               ExclamationMarkBehavior childGameObject = Instantiate(exclamationMark, gameObject.transform);
                childGameObject.name = "InstantiateChild";
                attacking = true;
            }
        }
        if(attacking == true) {
            
            if(time>10) {
                float angleToShoot = CustomMathFuncsPrototype.caculateAngleToLead(EnemyGameDataPrototype.player, transform.position,10f);
                if(angleToShoot < 0) {
                    angleToShoot += 2 * Mathf.PI;
                }
                projectilePrefab.direction = new Vector3(Mathf.Cos(angleToShoot),Mathf.Sin(angleToShoot));
                Instantiate(projectilePrefab, transform.position, Quaternion.Euler(0, 0, angleToShoot * 180/Mathf.PI + 180));
                time = 0;
                 attacking = false;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision) {
        //if(collision.Parrent 0)
    }
}
