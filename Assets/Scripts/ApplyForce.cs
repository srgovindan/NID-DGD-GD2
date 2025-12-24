using UnityEngine;


//Put this script on an object to apply force at start 
public class ApplyForce : MonoBehaviour
{
    //References
    private Rigidbody rb;
    
    public float force;
    public Vector3 direction;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Get references
        rb = GetComponent<Rigidbody>();

        
        //create the force vector 
        Vector3 forceVector = direction * force;

        //apply force to the rigidbody in one direction to the ball 
        rb.AddForce(forceVector);
    }
    
    
}
