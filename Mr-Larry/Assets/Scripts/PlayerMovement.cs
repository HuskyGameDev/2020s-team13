using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 velocity;
    public float xMovement = 20f;
    public float yMovement = 20f;
    public SpriteRenderer spr;

    
    public Sprite BaseLarry;
    public Sprite LarryLevel1;
    public Sprite LarryLevel2;
    public Sprite LarryLevel3;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float acceleration = xMovement;
        float deceleration = acceleration;
        float moveInputX = Input.GetAxisRaw("Horizontal");
        float moveInputY = Input.GetAxisRaw("Vertical");
        float power = SliderScript.power;

        // spr = GetComponent<SpriteRenderer>();
        

        //chane image based on sliderVal
        print(power);
        switch(power) {
            case 1:
                spr.sprite = BaseLarry;
                break;
            case 2:
                spr.sprite = LarryLevel1;
                break;
            case 3:
                spr.sprite = LarryLevel2;
                break;
            case 4:
                spr.sprite = LarryLevel3;
                break;
            default: 
                spr.sprite = BaseLarry;
                break;
        }

        /*if (Input.GetKey("w"))
        {
            Debug.Log("w");
            if(rb.velocity.y < 0)
            {
                rb.velocity.Set(rb.velocity.x, 0f);
            }
            transform.position.Set(transform.position.x, transform.position.y + yMovement * Time.deltaTime, transform.position.z);
        }
        if (Input.GetKey("s"))
        {
            if (rb.velocity.y > 0)
            {
                rb.velocity.Set(rb.velocity.x, 0f);
            }
            transform.position.Set(transform.position.x, transform.position.y + yMovement * Time.deltaTime, transform.position.z);
            //rb.AddForce(0, -yMovement * Time.deltaTime, 0);
        }*/
        if (Input.GetKey("a"))
        {
            spr.flipX = true;
        }
        if (Input.GetKey("d"))
        {
            spr.flipX = false;
        }
        if (moveInputX != 0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, xMovement * moveInputX, acceleration * Time.deltaTime);
        }
        else if (moveInputY != 0)
        {
            velocity.y = Mathf.MoveTowards(velocity.y, yMovement * moveInputY, acceleration * Time.deltaTime);
        }
        else
        {
            velocity.x = Mathf.MoveTowards(velocity.x, 0, deceleration * Time.deltaTime);
            velocity.y = Mathf.MoveTowards(velocity.y, 0, deceleration * Time.deltaTime);
        }

        transform.Translate(velocity * Time.deltaTime);
    }
}