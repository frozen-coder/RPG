using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDataPrototype : MonoBehaviour
{
    public static EnemyDataPrototype instance { get; private set; }


    public static VelocityPosition player;

    public static int Lives;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more than one Data Persistence Manager in the scene.");
        }
        Lives = 5;
        instance = this;
    }
    private void FixedUpdate()
    {
        Debug.Log("Player position: " + player.getPosition() + "\n" +"Player velocity" + player.getVelocityVector());
    }
}
