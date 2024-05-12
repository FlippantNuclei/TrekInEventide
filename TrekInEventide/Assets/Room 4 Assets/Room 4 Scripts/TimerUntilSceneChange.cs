using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerUntilSceneChange : MonoBehaviour
{
    public int sceneChange;
    public int playBell;
    public int arrivalTime;

    [Header("Sound")]
    public AudioSource arrivalMessage;
    public AudioSource bellSound;

    [Header("Train")]
    
    public Animator trainSpeed;
    public Animator trainStop;

    public GameObject canvasFade;
    public GameObject fade;

    void Start()
    {
        StartCoroutine(CheckTime());
        StartCoroutine(SoundAgain());
        //StartCoroutine(FadeOut());
        
    }

    public IEnumerator SoundAgain()
    {
        yield return new WaitForSeconds(playBell);
        //music.enabled = false;
        bellSound.Play();
        canvasFade.SetActive(true);
        fade.SetActive(false);
    }

    public IEnumerator CheckTime()
    {
        yield return new WaitForSeconds(arrivalTime);
        arrivalMessage.Play();
        //rainSpeed.SetTrigger("Slow");
        trainStop.SetTrigger("Fade");
    }

   
    
  
}
