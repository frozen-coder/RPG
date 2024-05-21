using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArrowBehavior : MonoBehaviour
{
    //todo
    //make these vals dependent on a scriptable objecth tat keeps track of player stats
     public float Speed = 4.5f;
    public Vector3 direction;
    public float timeAlive;
    //todo make this damage actually do somthing
    public int damage;

    //When object is enstanciated
    void Awake()
    {
        timeAlive = 0;
        print("IM AALIVE!");
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += Speed * direction * Time.deltaTime;
        timeAlive += Time.deltaTime;
        if (timeAlive > 5)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided into " + collision + ". Parent = " + collision.gameObject);
        Destroy(gameObject);
    }
}
