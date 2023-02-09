using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [Header("Set Timer Here, Set in (second)")]
    public float timeLimit = 30.0f;

    private float timeRemaining;
    [Header("Please Ignore")]
    public Text timerText;
    [HideInInspector] public bool stopTimer;


    private void Start()
    {
        timeRemaining = timeLimit;
        stopTimer = false;
    }

    private void Update()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60.0f);
        int seconds = Mathf.FloorToInt(timeRemaining % 60.0f);

        if (!stopTimer)
        {
            timeRemaining -= Time.deltaTime;
        }

        timerText.text = string.Format("{00:00}:{01:00}", minutes, seconds);
        if (timeRemaining <= 0 )
        {
            timerText.text = string.Format("{00:00}:{01:00}", 0, 0);
            HealthBar.currentHealth = 0;
        }
    }
}
