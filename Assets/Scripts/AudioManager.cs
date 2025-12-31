using UnityEngine;


/// <summary>
/// This script will select a random BGM track from a list at start.
/// Then it loops that track.
/// </summary>
public class AudioManager : MonoBehaviour
{
    public AudioClip[] bgmTracks;
    
    void Start()
    {
        //Get reference to the audio source
        AudioSource audioSource = GetComponent<AudioSource>();
        
        //pick a random bgm track 
        AudioClip clipToPlay = bgmTracks[Random.Range(0, bgmTracks.Length - 1)];
        
        //change the clip set on the audio source
        audioSource.clip = clipToPlay;
        
        //change the volume
        audioSource.volume = .75f;

        //play the track
        //dont need to call this if we already have play on start enabled 
        //GetComponent<AudioSource>().Play();
    }
    
}
