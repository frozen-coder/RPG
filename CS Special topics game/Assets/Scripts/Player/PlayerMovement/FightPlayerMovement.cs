using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightPlayerMovement : MonoBehaviour
{
    
    public float speed;
    public TempPlayerData tempPlayerData;
    public Rigidbody2D rb;
    public Vector2 moveVelocity;
    
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        tempPlayerData.currentPosition = new Vector2(0,0);
        rb.position = tempPlayerData.currentPosition;
        Debug.Log(tempPlayerData.currentPosition);
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
        tempPlayerData.velocity = moveVelocity;
    }
    // called every physics update
    void FixedUpdate()
    {
        // fixedDeltaTime checks how long it has been since last physics update
        if (!tempPlayerData.moveLock)
        {
            rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
            tempPlayerData.currentPosition = rb.position;
        }
    }
}
