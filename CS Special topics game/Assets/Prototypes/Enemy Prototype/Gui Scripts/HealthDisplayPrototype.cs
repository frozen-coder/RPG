using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NewBehaviourScript : MonoBehaviour
{
    public TMP_Text healthText;
    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health : " +EnemyGameDataPrototype.Lives;
    }
}
