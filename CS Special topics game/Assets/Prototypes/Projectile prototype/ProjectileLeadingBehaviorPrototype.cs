using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ProjectileLeadingBehaviorPrototype : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 10f;
    public Vector2 startPosition;
    public Vector3 direction;
    public float timeAlive;
    public ProjectileLeadingBehaviorPrototype()
    {
        timeAlive = 0;
    }
    public Vector3 FindDirection(Vector2 targetVelocity, Vector2 targetPos, Vector2 startPos) {
        float targetSpeed = targetVelocity.magnitude;
        //angle of vector between the start pos and target
        float angleOfDisplacment = Mathf.Atan2(targetPos.y - startPos.y, targetPos.x - startPos.x);
        float angleOfTargetVelocity = Mathf.Atan2(targetVelocity.y, targetVelocity.x);
        float angleToShoot = angleOfDisplacment - Mathf.Asin((targetSpeed / Speed) * Mathf.Sin(angleOfDisplacment - angleOfTargetVelocity));
        Debug.Log("ANgle To Shoot " + angleToShoot);
        return new Vector3(Mathf.Cos(angleToShoot), Mathf.Sin(angleToShoot), 0);
    }
    // Update is called once per frame
    void Update()
    {
        //try {
            transform.position += Speed * direction * Time.deltaTime;
        //}
       // catch e) {
           // Error.Log(e);
        //}
        timeAlive += Time.deltaTime;
        if (timeAlive > 5)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided into " + collision + ". Parrent = " + collision.gameObject);
        if(collision.gameObject.name != "RedMan") {
            Destroy(gameObject);
        }
    }
}
