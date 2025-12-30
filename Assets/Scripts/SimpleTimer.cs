using UnityEngine;

public class SimpleTimer : MonoBehaviour
{
    public float timerDuration = 2f;
    private float timer= 0f;

    public PlayAudio myAudioScript;
    
    // Update is called once per frame
    void Update()
    {
        //gives us the time since the start of the game running
        //Debug.Log(Time.time);

        if (timer < timerDuration)
        {
            timer = timer + Time.deltaTime;
            //Debug.Log(timer);
        }
        else
        {
            //the timer duration has passed 
            //do something else 
            //Debug.Log("DO COOL TIMED STUFF.");
            
            //play the audio from another audio source 
            //myAudioScript.audioSource
            //myAudioScript.
            
            timer = 0;
        }
        
    }
}
