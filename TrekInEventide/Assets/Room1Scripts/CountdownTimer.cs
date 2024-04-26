using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public float totalTime = 300f; // Total time for the countdown in seconds
    private float currentTime; // Current time left
    private TextMeshProUGUI timerText; // Reference to the TextMeshPro UI component

    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        currentTime = totalTime;
    }

    void Update()
    {
        // Update the current time
        currentTime -= Time.deltaTime;

        // Ensure the timer doesn't go below zero
        if (currentTime < 0)
        {
            currentTime = 0;
        }

        // Calculate minutes and seconds
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);

        // Update the timer text
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
