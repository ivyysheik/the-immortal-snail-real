using UnityEngine;
using TMPro;
using System.Diagnostics;
using System;

public class StopwatchUI : MonoBehaviour
{
    public TextMeshProUGUI stopwatchText; // Reference to the TextMeshProUGUI component
    public Stopwatch stopwatch;          // The Stopwatch instance

    private void Start()
    {
        // Initialize the Stopwatch
        stopwatch = new Stopwatch();

        // Ensure that the TextMeshProUGUI component is assigned
        if (stopwatchText == null)
        {
            UnityEngine.Debug.LogError("StopwatchText not assigned in the inspector!");
        }
    }

    private void Update()
    {
        // Start the stopwatch when the game starts or when needed
        if (!stopwatch.IsRunning)
        {
            stopwatch.Start();
        }

        // Update the displayed time every frame
        TimeSpan  timeSpan = stopwatch.Elapsed;

        // Update the TextMeshProUGUI text with the formatted time (HH:mm:ss:ff)
        stopwatchText.text = string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D2}",
            timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds / 10);
    }

    // Stop the stopwatch when needed
    public void StopStopwatch()
    {
        stopwatch.Stop();
    }

    // Reset the stopwatch to zero
    public void ResetStopwatch()
    {
        stopwatch.Reset();
    }
}

