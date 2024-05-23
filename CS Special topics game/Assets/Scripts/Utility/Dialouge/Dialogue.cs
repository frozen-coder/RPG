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
    int index = 0;
    private void Start()
    {
        gameObject.SetActive(false);
    }
    public void sayDialogue(string[] inputLines, string[] inputCharacters)
    {
        lines = inputLines;
        characters = inputCharacters;
        print("Hellllllo1!");
        gameObject.SetActive(true);
        StartDialogue();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (text.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                text.text = lines[index];
            }
        }
    }
    private void StartDialogue()
    {

        while (index < lines.Length)
        {
            
            speaker.text = characters[index];
            StartCoroutine(TypeLine());
        }
    }

    private IEnumerator TypeLine()
    {

        foreach (char c in lines[index])
        {
            text.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    private void NextLine()
    {
        if (index < lines.Length)
        {
            index++;
            text.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
