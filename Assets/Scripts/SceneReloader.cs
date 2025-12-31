using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    
    //SINGLETON REFERENCE
    public static ChangeScenes instance;
    
    //Keys 
    public KeyCode scene1key;
    public KeyCode scene2key;
    public KeyCode scene3key;

    void Start()
    {
        //SINGLETON
        if (instance == null)
        {
            //setting the reference variable to this version of the script 
            Debug.Log("created this object and setting it as the reference");
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            //destroy any other script that has been made 
            Debug.Log("destroying another instance of this script!");
            Destroy(gameObject);
        }
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            //reload the current scene 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        if (Input.GetKeyDown(scene1key))
        {
            //load the first scene
            Debug.Log("load the first scene");
            SceneManager.LoadScene("1_Sprites");
        }

        if (Input.GetKeyDown(scene2key))
        {
            //load the second scene
            Debug.Log("load the second scene");
            SceneManager.LoadScene("2_PhysicsJoints");
        }

        if (Input.GetKeyDown(scene3key))
        {
            Debug.Log("load the third scene");
            SceneManager.LoadScene("3_Singletons");
        }
    }
}
