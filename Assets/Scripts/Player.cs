using UnityEngine;

public class Player : MonoBehaviour
{

    public ParticleSystem confettiParticleSystem;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //call the function from the GameManager
            //the GM is a singleton so we can access it like this
            GameManager.instance.ChangePoints(7);
        }
        
        //if the player gets 20 points or more,
        if (GameManager.instance.points > 20)
        {
            //play the confetti particle system
            confettiParticleSystem.Play();
        }

    }
    
    
    
}
