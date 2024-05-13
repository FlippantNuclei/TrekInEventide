using UnityEngine;
using System.Collections;

public class RandomAudioPlayer : MonoBehaviour
{
    // Array to hold the AudioSources
    public AudioSource[] audioSources;

    // Minimum and maximum time between audio plays
    public float minTimeBetweenPlays = 2f;
    public float maxTimeBetweenPlays = 5f;

    // Start is called before the first frame update
    void Start()
    {
        // Start the coroutine to play audio clips randomly
        StartCoroutine(PlayRandomAudio());
    }

    // Coroutine to play audio clips randomly
    IEnumerator PlayRandomAudio()
    {
        while (true)
        {
            // Wait for a random amount of time between plays
            yield return new WaitForSeconds(Random.Range(minTimeBetweenPlays, maxTimeBetweenPlays));

            // Choose a random AudioSource from the array
            AudioSource randomSource = audioSources[Random.Range(0, audioSources.Length)];

            // Play the chosen AudioSource
            randomSource.Play();
        }
    }
}
