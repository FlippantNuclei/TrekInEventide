using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class SceneChange : MonoBehaviour
{
    [CommandInfo("Custom", "Load Next Scene", "Loads the next scene after conversation ends.")]
    public class LoadNextScene : Command
    {
        public string nextSceneName; // Name of the next scene to load

        public override void OnEnter()
        {
            base.OnEnter();

            // Load the next scene
            SceneManager.LoadScene(nextSceneName);

            // Tell Fungus to continue executing commands after this one
            Continue();
        }
    }
}
