using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar : MonoBehaviour
{
    public Rigidbody rb;
    public float yMovement = 500f;
    public float gravity = 150f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("o"))
        {
            rb.AddForce(0, yMovement * Time.deltaTime, 0);
        }
        rb.AddForce(0, -gravity* Time.deltaTime, 0);
    }
}
