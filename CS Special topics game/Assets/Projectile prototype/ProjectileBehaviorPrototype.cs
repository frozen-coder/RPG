using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviorPrototype : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 4.5f;
    public Vector3 direction;
    public float timeAlive;
    public ProjectileBehaviorPrototype() {
        timeAlive = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.position += Speed * direction * Time.deltaTime;
        timeAlive += Time.deltaTime;
        if(timeAlive > 5) {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        Debug.Log("Collided into " + collision + ". Parrent = " + collision.gameObject);
        Destroy(gameObject);
    }
}
