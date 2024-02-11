using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviorPrototype : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 4.5f;
    public Vector2 direction;
    private Rigidbody2D rb;
    public ProjectileBehaviorPrototype(Vector2 direction) {
        this.direction = direction;
        rb = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position + Speed * direction * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        Debug.Log("Collided into " + collision + ". Parrent = " + collision.gameObject);
        Destroy(gameObject);
    }
}
