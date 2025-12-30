using UnityEngine;

public class PlayAudio : MonoBehaviour
{

    public AudioSource audioSource;

    public float Volume; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
