using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePrototypePlayerControllerPrototype : MonoBehaviour
{
    public float speed;

    public Rigidbody2D rb;

    public Vector2 moveVelocity;

    public Transform center;

    public ProjectileBehaviorPrototype ProjectilePrefab;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
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
        if (Input.GetButtonDown("Fire1")) 
        {
            Vector2 ProjectileDirection = rb.position.normalized;
            Debug.Log("Target at " + rb.position + "\n" + "Targeting " + rb.position.normalized * rb.position.magnitude);
            ProjectilePrefab.direction = new Vector3(ProjectileDirection.x, ProjectileDirection.y);
            Instantiate(ProjectilePrefab, Vector2.zero, Quaternion.Euler(0, 0, Mathf.Atan2(rb.position.y, rb.position.x) * 180/Mathf.PI + 180));
        }
    }
    // called every physics update
    void FixedUpdate()
    {
        // fixedDeltaTime checks how long it has been since last physics update
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
    
    
}
