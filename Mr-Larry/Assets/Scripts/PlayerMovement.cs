using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float xMovement=500f;
    public float yMovement = 500f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
            {
            rb.AddForce(0, yMovement * Time.deltaTime, 0);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, -yMovement * Time.deltaTime, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-xMovement * Time.deltaTime, 0,0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(xMovement * Time.deltaTime, 0,0);
        }
    }
}
