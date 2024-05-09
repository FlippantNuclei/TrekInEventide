using UnityEngine;
using Fungus;
using System.Collections;

//[CommandInfo("Custom", "Enable Screenshot", "Enables the screenshot function.")]
//public class enableScreenShot : Command
//{
//    public GameObject photoCapture;

//    public float delayTime = 1f; // Adjust this value as needed

//    public override void OnEnter()
//    {
//        base.OnEnter();

//        photoCapture.SetActive(true);

//        // Start a coroutine to delay execution
//        StartCoroutine(DelayedContinue());

//        // No need to call Continue() here, as it will be called after the delay
//    }

//    private IEnumerator DelayedContinue()
//    {
//        // Wait for the specified delay time
//        yield return new WaitForSeconds(delayTime);

//        // Continue executing commands after the delay
//        Continue();
//    }
//}

public class enableScreenShot :MonoBehaviour
{
    public GameObject screenShot;
    public void enableScreenShotFun()
    {
        screenShot.SetActive(true);
    }
}
