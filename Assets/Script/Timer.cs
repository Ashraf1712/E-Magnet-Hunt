using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [Header("Set Timer Here, Set in (second)")]
    public float timeLimit = 30.0f; // The time limit in seconds

    private float timeRemaining; // The time remaining
    [Header("Please Ignore")]
    public Text timerText; // The UI text component to display the timer

    private void Start()
    {
        timeRemaining = timeLimit; // Initialize the time remaining
    }

    private void Update()
    {
        // Decrement the time remaining by the time elapsed since the last frame
        timeRemaining -= Time.deltaTime;

        // Convert the time remaining into minutes and seconds
        int minutes = Mathf.FloorToInt(timeRemaining / 60.0f);
        int seconds = Mathf.FloorToInt(timeRemaining % 60.0f);

        // Update the timer text
        timerText.text = string.Format("{00:00}:{01:00}", minutes, seconds);

        // Check if the timer has reached zero
        if (timeRemaining <= 0)
        {
            timerText.text = string.Format("{00:00}:{01:00}", 0, 0);
        }
    }
}
