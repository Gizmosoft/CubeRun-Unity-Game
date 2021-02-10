using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 1200f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update - called only once at the start of the game
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()      // Fixed update is used for Physics manipulations - Better than Update()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < 0f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
