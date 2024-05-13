using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Room1SceneLoader : MonoBehaviour
{
    // Name of the scene to load
    public string sceneName;

    // Function to be called when the button is clicked
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
