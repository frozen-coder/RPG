using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayerControllerPrototype : MonoBehaviour
{
    public float speed;

    public Rigidbody2D rb;

    private Vector2 moveVelocity;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        EnemyGameDataPrototype.player = rb;
    }
    // Start is called before the first frame update

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //keys axis are tied to can be changed here: Edit > Project Settings > Input Manager
        //when left arrow key is held down, horizontal is negative, right key is positive, up arrow is po
        //represents a vector in 2d space
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        // .normalized sets magnitude of vector to 1
        moveVelocity = moveInput.normalized * speed;

        //will fire arrows at the player from 0,0
        

    }
    // called every physics update
    void FixedUpdate()
    {
        // fixedDeltaTime checks how long it has been since last physics update
        rb.velocity = moveVelocity;
        EnemyGameDataPrototype.player = rb;
    }
    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.name == "EnemyProjectile") {
            string target = "DeathPrototype";
            PrototypeEnemySceneManager.CustomLoadScene(target);

        }

    }
    
    
}