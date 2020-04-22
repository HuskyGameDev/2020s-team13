using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MunchScript : MonoBehaviour
{
    public AudioSource[] sounds;
    public AudioSource munch;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            munch.Play();
            Destroy(other.gameObject);
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