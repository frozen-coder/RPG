using UnityEngine;

[CreateAssetMenu]
public class TempPlayerData : ScriptableObject
{
    public bool moveLock;
    public Vector3 currentPosition;
    public Vector2 velocity;
    public float hp;
}