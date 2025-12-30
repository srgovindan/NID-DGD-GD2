using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{

    void Update()
    {
        //if we press the r button 
        if (Input.GetKeyDown(KeyCode.R))
        {
            //reload the current scene
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            //UnityEngine.SceneManagement.SceneManager.LoadScene("2_PhysicsJoints");
        }
    }
}
