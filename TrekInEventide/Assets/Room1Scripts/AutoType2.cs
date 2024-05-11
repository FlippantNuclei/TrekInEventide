using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class AutoType2 : MonoBehaviour
{
    public TMP_InputField inputField;
    private Dictionary<int, string> sentenceDictionary = new Dictionary<int, string>();
    private bool isTyping = false;

    void Start()
    {
        // Initialize the sentences for each button
        //1 is the begining
        //2 is the start
        //3 is RecycleBin-???.txt
        //4 is folder
        //5 is emial
        //6 is My Website
        sentenceDictionary.Add(1, "\n.....\nHello？\n...\nTime and place...  how should I define this place?\n...\nI remember this interface, it was my first computer.\nI used it for 6 years until I was 13.\nIt's too old to even stream videos online.\nBut it stores a lot of important memories for me.\n...\n.......");
        sentenceDictionary.Add(2, "\n....\nMaybe by restarting it I can put an end to this.\nI'm going to find the key.\n...\n....");
        sentenceDictionary.Add(3, "\n. . . I exist. . . . I want to know why I exist.\n..\nMaybe nothing matters anymore,\nthe only thing that matters to me is \nthat I want to know why I'm here.\n...\n....");
        sentenceDictionary.Add(4, "\n...My folder.....\nThis is where I put my electronic diary.\nWhat will be in it...\nI need to unlock the password of the folder.\n...\n....");
        sentenceDictionary.Add(5, "\nRylen, I know that's my name.\n..\nMy name is Rye...Rylen\n..\nSomething bad happened. \nBut I don’t remember what happened before..\n or after..\n...\n....");
        sentenceDictionary.Add(6, "\nThis is my website.\nI've written many, many stories. \nThis is my first serialized story.\nHow childish and ridiculous it is.\n....\nIt's also...quite cute.\n...\nThe password to open the folder may be in it.\n...\n....");
        sentenceDictionary.Add(7, "\nSeventh sentence.");
        sentenceDictionary.Add(8, "\nEighth sentence.");
        sentenceDictionary.Add(9, "\nNinth sentence.");
        sentenceDictionary.Add(10, "\nTenth sentence.");
    }

    public void SetActiveSentence(int buttonIndex)
    {
        // Only set the sentence if not currently typing and button index exists in dictionary
        if (!isTyping && sentenceDictionary.ContainsKey(buttonIndex))
        {
            StartCoroutine(TypeSentence(sentenceDictionary[buttonIndex]));
        }
    }

    IEnumerator TypeSentence(string sentence)
    {
        isTyping = true;

        foreach (char letter in sentence)
        {
            inputField.text += letter;
            yield return new WaitForSeconds(0.05f); // Adjust typing speed as needed
        }

        // Add a delay after typing the sentence
        yield return new WaitForSeconds(1f);

        isTyping = false;
    }
}