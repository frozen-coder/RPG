using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI speaker;
    // first one is the line, second is the character
    private string[] lines;
    private string[] characters;
    public float textSpeed;
    private int speed;
    public TempPlayerData tempPlayerData;
    bool lineDone = false;
    int index = 0;
    public static bool dialogActive = false;
    private void Start()
    {
        gameObject.SetActive(false);
    }
    public void sayDialogue(string[] inputLines, string[] inputCharacters)
    {
        dialogActive = true;
        index = 0;
        lines = inputLines;
        characters = inputCharacters;
        print("Hellllllo1!");
        gameObject.SetActive(true);
        tempPlayerData.moveLock = true;

        NextLine();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (index == lines.Length)
            {

                NextLine();
            }
            else if (lineDone)
            {
                index++;
                NextLine();

            }
            else
            {
                StopAllCoroutines();
                text.text = lines[index];
                lineDone = true;
            }
        }
    }
    /*
    private void StartDialogue()
    {

        while (index < lines.Length)
        {
            
            speaker.text = characters[index];
            NextLine();
        }
    }
    */
    private IEnumerator TypeLine()
    {

        foreach (char c in lines[index])
        {
            text.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
        lineDone = true;

    }
    private void NextLine()
    {
        lineDone = false;
        if (index < lines.Length)
        {
            print(index);

            text.text = string.Empty;
            speaker.text = characters[index];
            StartCoroutine(TypeLine());

        }
        else
        {
            print("HIDOIDOIFOID");
            dialogActive = false;
            tempPlayerData.moveLock = false;
            gameObject.SetActive(false);
        }
    }
}
