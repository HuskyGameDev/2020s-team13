using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour {

    public Rigidbody rb;
    public float speed;
    public float swimTime;
    private float swimCounter;

    private int swimDirection;
    private bool notEaten;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        swimCounter -= Time.deltaTime;
        if(swimCounter < 0) {
            chooseDirection();
        } else {
            switch(swimDirection) {
                case 0:
                    rb.velocity = new Vector3(0, speed, 0);
                    break;
                case 1:
                    rb.velocity = new Vector3(speed, speed, 0);
                    break;
                case 2:
                    rb.velocity = new Vector3(speed, 0, 0);
                    break;
                case 3:
                    rb.velocity = new Vector3(speed, -speed, 0);
                    break;
                case 4:
                    rb.velocity = new Vector3(0, -speed, 0);
                    break;
                case 5:
                    rb.velocity = new Vector3(-speed, -speed, 0);
                    break;
                case 6:
                    rb.velocity = new Vector3(-speed, 0, 0);
                    break;
                case 7:
                    rb.velocity = new Vector3(-speed, speed, 0);
                    break;
            }
        }
    }

    public void chooseDirection() {
        swimDirection = Random.Range(0, 8);
        swimCounter = swimTime;
    }
}
