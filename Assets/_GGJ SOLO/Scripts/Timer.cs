using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] float gameTimer;
    private float gameDuration; // The duration of the game in seconds
    private float currentTime; // The current time in seconds
    private bool isTimerRunning; // Flag to check if the timer is currently running
    private UnityAction timerEndAction; // Action to be invoked when the timer ends

    // Event to notify when the timer ends
    public event UnityAction TimerEnded;

    private float currentTimePercentage;
    private float objectsCountPercentage;

    private void Start()
    {
        // Start the timer with a duration of 10 seconds
        StartTimer(gameTimer);
    }

    // Start the timer with the specified duration
    public void StartTimer(float duration, UnityAction endAction = null)
    {
        gameDuration = duration;
        currentTime = gameDuration;
        isTimerRunning = true;
        timerEndAction = endAction;
    }

    // Stop the timer and reset the current time
    public void StopTimer()
    {
        isTimerRunning = false;
        currentTime = 0f;
    }

    public void PauseTimer()
    {
        isTimerRunning = false;
    }

    public void ResumeTimer()
    {
        isTimerRunning = true;
    }

    private void Update()
    {
        if (isTimerRunning)
        {
            currentTime -= Time.deltaTime;

            currentTime = Mathf.Clamp(currentTime, 0f, gameTimer);
            currentTimePercentage = currentTime / gameTimer;

            objectsCountPercentage = GameManager.instance.objectsCount / GameManager.instance.maxObjectsThisLevel;

            GameManager.instance.score = (currentTimePercentage * 1000) + (objectsCountPercentage * 1000);

            Debug.Log("Score : " + GameManager.instance.score.ToString(".000"));

            GameManager.instance.scoreText.text = ("Score : ") + GameManager.instance.score.ToString("0.000");
            GameManager.instance.timerText.text = ("Timer : ") + currentTime.ToString("0.00");
            GameManager.instance.scoreText.text = ("Score : ") + GameManager.instance.score.ToString("0");

            if (currentTime <= 0f)
            {
                // Timer has ended
                isTimerRunning = false;
                currentTime = 0f;

                // Invoke the timer end action if specified
                timerEndAction?.Invoke();

                // Raise the TimerEnded event
                TimerEnded?.Invoke();
            }
        }
    }
}