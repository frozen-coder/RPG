using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityPosition
{
    private Vector2 velocityVector;
    private Vector2 position;
    public void setVelocityVector(Vector2 velocityVector) { 
        this.velocityVector = velocityVector;
    }
    public void setPosition(Vector2 position)
    {
        this.position = position;
    }
    public Vector2 getVelocityVector()
    {
        return velocityVector;
    }
    public Vector2 getPosition()
    {
        return position;
    }

}
