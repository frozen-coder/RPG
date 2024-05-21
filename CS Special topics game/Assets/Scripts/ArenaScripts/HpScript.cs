using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HpScript : MonoBehaviour
{
    public TMP_Text healthText;
    public TempPlayerData fightPlayerData;
    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health : " +fightPlayerData.hp;
    }
}
