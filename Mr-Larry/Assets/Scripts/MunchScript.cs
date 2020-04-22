using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MunchScript : MonoBehaviour
{
    public AudioSource[] sounds;
    public AudioSource munch;
    public static int score = 0;

    private IEnumerator OnTriggerEnter2D(Collider2D other)
    {
        
        float power = SliderScript.power;
        if (other.CompareTag("level1") && power == 1)
        {
            munch.Play();
            other.gameObject.SetActive(false);
            score+=1;
            yield return new WaitForSeconds(3);
            other.gameObject.SetActive(true);            
        }
        if (other.CompareTag("level2") && power == 2)
        {
            munch.Play();
            other.gameObject.SetActive(false);
            score+=10;
            yield return new WaitForSeconds(3);
            other.gameObject.SetActive(true);            
        }
        if (other.CompareTag("level3") && power == 3)
        {
            munch.Play();
            other.gameObject.SetActive(false);
            score+=100;
            yield return new WaitForSeconds(3);
            other.gameObject.SetActive(true);
        }
        if (other.CompareTag("level4") && power == 4)
        {
            munch.Play();
            other.gameObject.SetActive(false);
            score+=500;
            yield return new WaitForSeconds(3);
            other.gameObject.SetActive(true);
        }
    }

    void FixedUpdate()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        sounds = GetComponents<AudioSource>();
        munch = sounds[2];
    }

    // Update is called once per frame
    void Update()
    {

    }
}