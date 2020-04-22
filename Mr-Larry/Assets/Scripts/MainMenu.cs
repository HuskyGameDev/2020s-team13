using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource source;
    private int i;
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        source = GetComponent<AudioSource>();
        i = 0;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            source.Play();
            while(i < 200)
            {
                i++;
            }
            StartGame();
        }
    }
}
