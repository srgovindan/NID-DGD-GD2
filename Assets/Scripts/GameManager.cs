using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    //SINGLETON
    public static GameManager instance;
    
    //Public
    public int points;
    
    void Start()
    {
        //SINGLETON
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
        //Set Points
        ChangePoints(0);
    }

    public void ChangePoints(int changeInPoints)
    {
        points = points + changeInPoints;
        Debug.Log("Points: " + points);
        
        //do stuff when you get more than 20 points
        if (points > 20)
        {
            //find the player game object
            Player player = FindFirstObjectByType<Player>();
            
            //play confetti from player object 
            player.PlayConfettiFX();
            
        }
    }
}
