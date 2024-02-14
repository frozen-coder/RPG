using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExclamationMarkBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer sr;
    private bool decreaseAlpha = false;
    private Color currColor = new Color(1,1,1,0.25f);
    private float time = 0;
    public ExclamationMarkBehavior() { 
    }
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = currColor;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (decreaseAlpha)
        {
            currColor.a = currColor.a - 0.01f;
            if (currColor.a < .5)
            {
                decreaseAlpha = false; ;
            }
        }
        else {
            currColor.a = currColor.a + 0.01f;
            if (currColor.a > .99) {
                decreaseAlpha = true;
            }
        }
        sr.color= currColor;
        if (time > 5) {
            Destroy(gameObject);
        }
    }
}
