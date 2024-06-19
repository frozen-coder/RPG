using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] sprites;
    public SpriteRenderer spriteRenderer; 
    private int direction = 0;
    private int framesSinceLastAnimation = 0;
    private int cycle = -1;
    private int framesPerAnimation = 10;
    private int spriteArrayOffset = 0;
    public TempPlayerData tempPlayerData;
    //0 down, 1 right, 2 up, 3 left

    // Update is called once per frame
    void FixedUpdate()
    {
        if(tempPlayerData.moveLock) {
            framesSinceLastAnimation = -1;
            cycle = 0;
        }
        else if(Input.GetAxisRaw("Vertical") == -1) {
            spriteArrayOffset = 0;
            if(direction!=0 || framesSinceLastAnimation == -1) {
                direction =0;
                cycle = 1;
                framesSinceLastAnimation = 0;
                spriteRenderer.sprite = sprites[cycle + spriteArrayOffset];
            }
            else if(framesSinceLastAnimation< framesPerAnimation) {
                framesSinceLastAnimation ++;
            }
            else {
                framesSinceLastAnimation = 0;
                cycle = (cycle + 1) % 5;
            }

        }
        
        else if(Input.GetAxisRaw("Horizontal") == 1) {
            spriteArrayOffset = 5;
            if(direction!=1 || framesSinceLastAnimation == -1) {
                direction =1;
                cycle = 1;
                framesSinceLastAnimation = 0;
                spriteRenderer.sprite = sprites[cycle + spriteArrayOffset];
            }
            else if(framesSinceLastAnimation< framesPerAnimation) {
                framesSinceLastAnimation ++;
            }
            else {
                framesSinceLastAnimation = 0;
                cycle = (cycle + 1) % 5;
            }
        }
        else if(Input.GetAxisRaw("Vertical") == 1) {
            spriteArrayOffset = 10;
            if(direction!=2 || framesSinceLastAnimation == -1) {
                direction =2;
                cycle = 1;
                framesSinceLastAnimation = 0;
                spriteRenderer.sprite = sprites[cycle + spriteArrayOffset];
            }
            else if(framesSinceLastAnimation< framesPerAnimation) {
                framesSinceLastAnimation ++;
            }
            else {
                framesSinceLastAnimation = 0;
                cycle = (cycle + 1) % 5;
            }
        } 
        else if(Input.GetAxisRaw("Horizontal") == -1) {
            spriteArrayOffset = 15;
             if(direction!=3 || framesSinceLastAnimation == -1) {
                direction =3;
                cycle = 1;
                framesSinceLastAnimation = 0;
                spriteRenderer.sprite = sprites[cycle + spriteArrayOffset];
            }
            else if(framesSinceLastAnimation< framesPerAnimation) {
                framesSinceLastAnimation ++;
            }
            else {
                framesSinceLastAnimation = 0;
                cycle = (cycle + 1) % 5;
            }
        }
        else {
            framesSinceLastAnimation = -1;
            cycle = 0;
        }
        spriteRenderer.sprite = sprites[cycle + spriteArrayOffset];
    }
}
