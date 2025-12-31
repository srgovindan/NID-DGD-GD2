using System;
using UnityEngine;

public class SimpleTimer : MonoBehaviour
{
    //Timer variables
    public float timerDuration = 2f;
    private float timer= 0f;
    
    //References
    private AudioManager audioManager;

    private void Start()
    {
        //Look for an audio manager in the scene
        audioManager = FindFirstObjectByType<AudioManager>();
    }

    void Update()
    {
        //Time.time gives us the time since the start of the game running
        //Debug.Log(Time.time);

        if (timer < timerDuration)
        {
            timer = timer + Time.deltaTime;
            //Debug.Log(timer);
        }
        else
        {
            //the timer duration has passed 
            Debug.Log("DO COOL TIMED STUFF.");
            
            //play the audio from the audio manager
            audioManager.PlayTimerEndClip();
            
            //reset the timer to 0
            timer = 0;
        }
        
    }
}
