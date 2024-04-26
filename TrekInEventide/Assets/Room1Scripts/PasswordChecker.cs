using UnityEngine;
using TMPro;

public class PasswordChecker : MonoBehaviour
{
    public TMP_InputField passwordInputField;
    public GameObject CorrectBox;
    public GameObject WrongBox;
    
    public GameObject PasswordBox;


    public string correctPassword;

    public void CheckPassword()
    {
        string inputPassword = passwordInputField.text;

        if (inputPassword == correctPassword)
        {
            // Activate the win canvas
            CorrectBox.SetActive(true);
            
            PasswordBox.SetActive(false);
            // Deactivate the lose canvas if it's active
            if (WrongBox.activeSelf)
            {
                WrongBox.SetActive(false);
            }
        }
        else
        {
            // Activate the lose canvas
            WrongBox.SetActive(true);
            // Deactivate the win canvas if it's active
            if (CorrectBox.activeSelf)
            {
                CorrectBox.SetActive(false);
            }
        }
    }
}
