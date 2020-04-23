using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameScript : MonoBehaviour
{
    public static bool IsPaused;
    public static bool IsGameOver;
    public GameObject gameOverMenu;
    public GameObject pauseMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        IsPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        float timer = Timer.currentTime;
        if (timer <= 0)
        {
            GameOver();
        }
        if (Input.GetKeyDown("p"))
        {
            if (IsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        if(Input.GetKeyDown(KeyCode.Return) && (IsPaused||IsGameOver))
        {
            LoadMenu();
        }
        if(Input.GetKeyDown(KeyCode.Escape) && (IsPaused||IsGameOver))
        {
            Quit();
        }
    }
    public void LoadMenu()
    {
        Resume(); // If not for this line of code, there will be an AudioListener bug, weird, but true.
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void Resume()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        IsPaused = false;
    }
    void Pause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        IsPaused = true;
    }
    void GameOver()
    {
        Time.timeScale = 0f;
        gameOverMenu.SetActive(true);
        IsGameOver = true;
    }
}
