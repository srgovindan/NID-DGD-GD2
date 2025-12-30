using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Vector3 spawnPos;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnTrapdoor();
        }
    }

    public void SpawnTrapdoor()
    {
        Debug.Log("Spawning a Trapdoor at :" + spawnPos);
        
        //create trapdoor! 
        //instantiate the prefab
        GameObject newTrapdoor = Instantiate(Resources.Load<GameObject>("Prefabs/Trapdoor"));

        //Disable the trapdoor so it doesn't interfere with the exsiting ones 
        newTrapdoor.gameObject.SetActive(false);
        //newTrapdoor.GetComponent<FixedJoint>()
        //newTrapdoor.AddComponent<>()
            
        //set the spawned gameobject to a new spawn position 
        newTrapdoor.transform.position = spawnPos;
        
        //Reactivate the trapdoor gameobject
        newTrapdoor.SetActive(true);
            
        //move the spawn position 
        spawnPos = spawnPos + new Vector3(1f, 1f, 1f);
    }
}
