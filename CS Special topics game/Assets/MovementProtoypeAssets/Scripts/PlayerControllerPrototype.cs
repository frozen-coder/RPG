using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerPrototype : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;
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
    }

    // called every physics update
    void FixedUpdate() {
        // fixedDeltaTime checks how long it has been since last physics update
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
