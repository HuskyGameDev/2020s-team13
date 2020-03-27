using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;
    public float swimTime;
    private float swimCounter;

    private int swimDirection;
    private bool notEaten;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        
        swimCounter -= Time.deltaTime;
        if(swimCounter < 0) {
            chooseDirection();
        } else {
            switch(swimDirection) {
                case 0:
                    rb.velocity = new Vector2(0, speed);
                    break;
                case 1:
                    rb.velocity = new Vector2(speed, speed);
                    break;
                case 2:
                    rb.velocity = new Vector2(speed, 0);
                    break;
                case 3:
                    rb.velocity = new Vector2(speed, -speed);
                    break;
                case 4:
                    rb.velocity = new Vector2(0, -speed);
                    break;
                case 5:
                    rb.velocity = new Vector2(-speed, -speed);
                    break;
                case 6:
                    rb.velocity = new Vector2(-speed, 0);
                    break;
                case 7:
                    rb.velocity = new Vector2(-speed, speed);
                    break;
            }
        }
    }

    public void chooseDirection() {
        swimDirection = Random.Range(0, 8);
        swimCounter = swimTime;
    }
}
