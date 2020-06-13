using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    //*******EXPIREMENTAL********\\
    public float yForce = 30f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        rb.AddForce(sidewaysForce, 0, 0 * Time.deltaTime);
        
        if (Input.GetKeyDown("space"))
        {
            //*******EXPIREMENTAL********\\
            rb.AddForce(0, yForce, 0 * Time.deltaTime);
        }
         
    }
}
//go to Brackeys video script was deleted