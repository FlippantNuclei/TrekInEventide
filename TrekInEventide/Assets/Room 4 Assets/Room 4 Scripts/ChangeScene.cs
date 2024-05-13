using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int NextScene;
    public int NextSceneNumber;
    public int FadeTimer;
    public int ActivateFade;

    [Header("Canvas")]
    public GameObject canvas;
    public GameObject fadeScreen;
    public Animator FadetheScreen;

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeToScene());
        StartCoroutine(ActivateTime());//This is the time it takes to activate the canvas and fade Screen
        StartCoroutine(FadeTime());//this will trigger the 
    }
    
    public IEnumerator FadeTime()
    {
        yield return new WaitForSeconds(FadeTimer);
        canvas.SetActive(true);
        fadeScreen.SetActive(true);
        
    }

    public IEnumerator ActivateTime()
    {
        yield return new WaitForSeconds(ActivateFade);
        FadetheScreen.SetTrigger("Cutscene");
        
    }

    public IEnumerator ChangeToScene()
    {
        yield return new WaitForSeconds(NextScene);
        SceneManager.LoadScene(NextSceneNumber);
        
    }

    
}
