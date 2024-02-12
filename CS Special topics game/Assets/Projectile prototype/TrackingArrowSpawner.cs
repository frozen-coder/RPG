using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingArrowSpawner : MonoBehaviour
{
    private float time = 0;
    // Start is called before the first frame update
    public ProjectilePrototypePlayerControllerPrototype player;
    public ProjectileLeadingBehaviorPrototype ProjectilePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 1) {
            Vector2 spawn = spawnLocation();
            Vector2 ProjectileDirection =(player.rb.position- spawn).normalized;
            
            ProjectilePrefab.direction = ProjectilePrefab.FindDirection(player.moveVelocity, player.rb.position, spawn);
            Debug.Log("Target at " + player.rb.position);
            ProjectilePrefab.startPosition = spawn;
            Instantiate(ProjectilePrefab, spawn, Quaternion.Euler(0, 0, Mathf.Atan2(ProjectilePrefab.direction.y, ProjectilePrefab.direction.x) * 180 / Mathf.PI + 180));
            time = 0;
        }
    }
    private Vector2 spawnLocation() {
        
        float angle = Random.value * 2 * Mathf.PI;
        Vector2 spawnLocation = (5 * new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)))+player.rb.position;
        return spawnLocation;
    }
    
}
