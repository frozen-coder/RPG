using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //dash will mult ur speed by 
    public float speed;
    public bool isFightPlayer;
    private float dashSpeedMult = 1f;
    private float maxDashSpeedMult = 10f;
    private int cooldownFrames = 0;
    private int maxCooldownFrames = 60;
    public TempPlayerData tempPlayerData;
    public Rigidbody2D rb;
    public Vector2 moveVelocity;
    private Vector2 moveInput;
    private int playerLayer = GameConstants.layerNameToNumber["Player"];
    private int invulnerableLayer = GameConstants.layerNameToNumber["Invulnerable"];
    private bool hasReleased = true;
    // Start is called before the first frame update
    void Start()
    {
        tempPlayerData.moveLock = false;
    
        rb = GetComponent<Rigidbody2D>();
        if(isFightPlayer) {
            tempPlayerData.currentPosition = new Vector2(0,0);
        }
        rb.position = tempPlayerData.currentPosition;
        setPlayerRegularLayers();
        Debug.Log(tempPlayerData.currentPosition);
    }

    // Update is called once per frame
    void Update()
    {
        //keys axis are tied to can be changed here: Edit > Project Settings > Input Manager
        //when left arrow key is held down, horizontal is negative, right key is positive, up arrow is po
        //represents a vector in 2d space
        if (!tempPlayerData.isDashing)
        {
           // print()
            moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
        
        // .normalized sets magnitude of vector to 1
        moveVelocity = moveInput.normalized * speed * dashSpeedMult;
        tempPlayerData.velocity = moveVelocity;
    }
    // called every physics update
    void FixedUpdate()
    {
        HandleDash();

        // fixedDeltaTime checks how long it has been since last physics update
        if (!tempPlayerData.moveLock)
        {
           // print("Yo");
            rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
            tempPlayerData.currentPosition = rb.position;
        }
    }
    private void HandleDash() {
        if (cooldownFrames > 0) { 
            cooldownFrames--;
            //print(cooldownFrames);
            if (cooldownFrames <= maxCooldownFrames-5)
            {
                setPlayerRegularLayers(); 
                tempPlayerData.isDashing = false;
                dashSpeedMult = 1f;
                gameObject.layer = playerLayer;
            }
        }
        
        else
        {
            
            if (Input.GetAxisRaw("Dash") != 1) {
                hasReleased = true;
            }
            if (Input.GetAxisRaw("Dash") == 1 && hasReleased) {
                setPlayerInvulnrableLayers();               
                tempPlayerData.isDashing = true;
                dashSpeedMult = maxDashSpeedMult;
                cooldownFrames = maxCooldownFrames;
                hasReleased = false;
                gameObject.layer = invulnerableLayer;
            }
            
        }
    }
    private void setPlayerInvulnrableLayers() {
         int invulnerablePlayerIncludeLayer = (1 << GameConstants.layerNameToNumber["Wall"]) | 1 << GameConstants.layerNameToNumber["Trigger"];
         int invulnerableLayerExcludeLayer = (1 << GameConstants.layerNameToNumber["Enemy Attacks"] | 1 << GameConstants.layerNameToNumber["Enemies"] | 1 << GameConstants.layerNameToNumber["Player Attacks"]);
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        Collider2D collider = gameObject.GetComponent<Collider2D>();
     gameObject.layer = GameConstants.layerNameToNumber["Invulnerable"];
        collider.includeLayers = invulnerablePlayerIncludeLayer;
        collider.excludeLayers = invulnerableLayerExcludeLayer;
        rb.includeLayers = invulnerablePlayerIncludeLayer;
        rb.excludeLayers = invulnerableLayerExcludeLayer;
    }
    private void setPlayerRegularLayers() {
        LayerMask regularPlayerIncludeLayer = (1 << GameConstants.layerNameToNumber["Wall"]) | 1 << GameConstants.layerNameToNumber["Enemies"] | 1 << GameConstants.layerNameToNumber["Enemy Attacks"] | 1 << GameConstants.layerNameToNumber["Trigger"];
        LayerMask regularPlayerExcludeLayer = (1 << GameConstants.layerNameToNumber["Player Attacks"]); 
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        Collider2D collider = gameObject.GetComponent<Collider2D>();
        gameObject.layer = GameConstants.layerNameToNumber["Player"];
        collider.includeLayers = regularPlayerIncludeLayer;
        collider.excludeLayers = regularPlayerExcludeLayer;
        rb.includeLayers = regularPlayerIncludeLayer;
        rb.excludeLayers = regularPlayerExcludeLayer;
    }
}

/*
class LayerSetter 
{
    public void setLayers(int layerMask) {

    }
    public void setEnemyLayers () {

    }
    
}
*/

