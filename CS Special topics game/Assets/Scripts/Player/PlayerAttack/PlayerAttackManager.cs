using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackManager : MonoBehaviour
{
    public Rigidbody2D rb;
    //could change later to handle multiple idffernt arrows
    //maybe add a function to PlayerArrowBehavior callsed set direction
    public PlayerArrowBehavior ProjectilePrefab;
    //TODO: Manage what attack the person is currentlly using
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1")) 
        {
        
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane;
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
            Vector2 displacment = worldPosition-rb.position;
            Debug.Log("Target at " + worldPosition);
            print(ProjectilePrefab);
            ProjectilePrefab.direction = (new Vector3(displacment.x, displacment.y)).normalized;
            Instantiate(ProjectilePrefab, rb.position, Quaternion.Euler(0, 0, Mathf.Atan2(displacment.y, displacment.x) * 180/Mathf.PI + 180));
           
        }
    }
}
