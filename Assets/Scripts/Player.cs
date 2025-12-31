using System;
using UnityEngine;

public class Player : MonoBehaviour
{

    private ParticleSystem confettiParticleSystem;
    private AudioSource audioSource;

    private void Start()
    {
        //get the reference to the particle system that is on a child game object 
        confettiParticleSystem = GetComponentInChildren<ParticleSystem>();

        //get the audio source component attached to this gameobject 
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //call the function from the GameManager
            //the GM is a singleton so we can access it like this
            GameManager.instance.ChangePoints(7);
        }
    }

    public void PlayConfettiFX()
    {
        Debug.Log("playing confetti particles and audio");
        
        //play the particle system
        confettiParticleSystem.Play();
        
        //play audio fx for confetti
        audioSource.Play();
    }
}
