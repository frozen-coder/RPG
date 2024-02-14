using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CustomMathFuncsPrototype 
{
    //only works if the projectile is able to hit
    public static float caculateAngleToLead(Vector2 targetVelocity, Vector2 targetStartPos, Vector2 projStartPos, float projSpeed) 
    {
         float targetSpeed = targetVelocity.magnitude;
        //angle of vector between the start pos and target
        float angleOfDisplacment = Mathf.Atan2(targetStartPos.y - projStartPos.y, targetStartPos.x - projStartPos.x);
        float angleOfTargetVelocity = Mathf.Atan2(targetVelocity.y, targetVelocity.x);
        float angleToShoot = angleOfDisplacment - Mathf.Asin((targetSpeed / projSpeed) * Mathf.Sin(angleOfDisplacment - angleOfTargetVelocity));
        return angleToShoot;
    }
    public static float caculateAngleToLead(Rigidbody2D targetRb, Vector2 projStartPos, float projSpeed)
    {
        float targetSpeed = targetRb.velocity.magnitude;
        Debug.Log("Target Speed = " + targetSpeed);
        //angle of vector between the start pos and target
        float angleOfDisplacment = Mathf.Atan2(targetRb.position.y - projStartPos.y, targetRb.position.x - projStartPos.x);
        float angleOfTargetVelocity = Mathf.Atan2(targetRb.velocity.y, targetRb.velocity.x);
        float angleToShoot = angleOfDisplacment - Mathf.Asin((targetSpeed / projSpeed) * Mathf.Sin(angleOfDisplacment - angleOfTargetVelocity));
        return angleToShoot;
    }
}
