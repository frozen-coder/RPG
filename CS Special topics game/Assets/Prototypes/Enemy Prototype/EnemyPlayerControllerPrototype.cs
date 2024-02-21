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
        /*
        if (Input.GetButtonDown("Fire1")) 
        {
            Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
            Vector2 displacment = worldPosition-rb.position;
            Debug.Log("Target at " + worldPosition);
            ProjectilePrefab.direction = new Vector3(displacment.x, displacment.y);
            Instantiate(ProjectilePrefab, rb.position, Quaternion.Euler(0, 0, Mathf.Atan2(displacment.y, displacment.x) * 180/Mathf.PI + 180));
        }
        */

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
            PlayerMangerScriptPrototype.playerHit();

        }

    }
    
    
}
