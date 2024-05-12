using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundController : MonoBehaviour
{
    public int timeTillDeparture;
    public int speaker;

 
    [Header("Sound")]
    public AudioSource music;
    public AudioSource bellSound;
    public AudioSource speakerSound;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimerCheck());
        StartCoroutine(Speaker());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator TimerCheck()
    {
        yield return new WaitForSeconds(timeTillDeparture);
        music.enabled = false;
        bellSound.Play();
    }
    
    public IEnumerator Speaker()
    {
        yield return new WaitForSeconds(speaker);
        speakerSound.Play();
        //fadeScreen.SetTrigger("Cutscene");
        
    }
}
