using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGameDataPrototype : MonoBehaviour
{
    public static EnemyGameDataPrototype instance { get; private set; }


    public static Rigidbody2D player;
    public static int playerLives;
    
    public static int Lives;
    private void Awake()
    {
        Lives = 5;
        if (instance != null)
        {
            Debug.LogError("Found more than one Data Persistence Manager in the scene.");
        }
        Lives = 5;
        instance = this;
    }
    private void FixedUpdate()
    {
        //Debug.Log("Player position: " + player.position + "\n" +"Player velocity" + player.velocity);
    }
}
