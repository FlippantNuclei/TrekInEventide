using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class AutoTypeSentence : MonoBehaviour
{
    public TMP_InputField inputField;
    private Queue<string> sentences = new Queue<string>();
    public float typingSpeed = 0.1f;

    private void Start()
    {
        // Add your sentences to the queue with each sentence starting with a newline character
        sentences.Enqueue("\nFirst sentence.");
        sentences.Enqueue("\nSecond sentence.");
        sentences.Enqueue("\nThird sentence.");

        StartCoroutine(TypeSentences());
    }

    IEnumerator TypeSentences()
    {
        yield return new WaitForSeconds(1f); // Wait for 10 seconds before typing

        while (sentences.Count > 0)
        {
            string sentence = sentences.Dequeue();

            foreach (char letter in sentence)
            {
                inputField.text += letter;
                yield return new WaitForSeconds(typingSpeed);
            }

            // Wait for a short delay after typing the sentence
            yield return new WaitForSeconds(0.5f);
        }

        // Add a newline followed by "-----END-----" at the end
        inputField.text += "\n-----END-----";
    }

    public void AddFourthSentence()
    {
        StartCoroutine(TypeFourthSentence());
    }

    IEnumerator TypeFourthSentence()
    {
        string fourthSentence = "\nFourth sentence.";
        foreach (char letter in fourthSentence)
        {
            inputField.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
