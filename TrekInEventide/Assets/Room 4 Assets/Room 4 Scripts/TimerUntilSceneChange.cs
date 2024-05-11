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
    public Animator trainSpeed;

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
    }

    public IEnumerator CheckTime()
    {
        yield return new WaitForSeconds(arrivalTime);
        arrivalMessage.Play();
        trainSpeed.SetTrigger("Slow");
    }

   
    
  
}
