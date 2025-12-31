using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject objectToSpawn;
    public Vector3 spawnPos;
    public Vector3 nextSpawnPosOffset = Vector3.one;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
        }
    }

    public void SpawnObject()
    {
        Debug.Log("Spawning " + objectToSpawn.name + " at :" + spawnPos);
        
        //instantiate the object from the reference
        GameObject newGameObject = Instantiate(objectToSpawn);
        
        //alternatively, we can instantiate the prefab from a filepath 
        //GameObject newGameObject = Instantiate(Resources.Load<GameObject>("Prefabs/Trapdoor"));

        //Disable the trapdoor so it doesn't interfere with the existing ones 
        newGameObject.gameObject.SetActive(false);
            
        //set the spawned gameobject to a new spawn position 
        newGameObject.transform.position = spawnPos;
        
        //Reactivate the trapdoor gameobject
        newGameObject.SetActive(true);
            
        //move the spawn position 
        spawnPos = spawnPos + nextSpawnPosOffset;
    }
}
