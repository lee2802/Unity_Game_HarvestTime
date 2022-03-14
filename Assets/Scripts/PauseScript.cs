using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public static bool GameisPaused = false;
    public GameObject pauseUI;
    public GameObject ButtonLeft;
    public GameObject ButtonRight;

    void Start()
    {
        pauseUI.SetActive(false);
    }

    public void pauseHit()
    {
        GameisPaused = true;
    }

    public void Update()
    {
        if (GameisPaused)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }

    public void Resume()
    {
        pauseUI.SetActive(false);
        ButtonLeft.SetActive(true);
        ButtonRight.SetActive(true);
        Time.timeScale = 1f;
        GameisPaused = false;
        FindObjectOfType<audioManager>().Resume("bgm");

    }

    public void Pause()
    {
        pauseUI.SetActive(true);
        ButtonLeft.SetActive(false);
        ButtonRight.SetActive(false);
        Time.timeScale = 0f;
        FindObjectOfType<audioManager>().Pause("bgm");
        GameisPaused = true;

    }

    public void Restart()
    {
        pauseUI.SetActive(false);
        ButtonLeft.SetActive(true);
        ButtonRight.SetActive(true);
        Time.timeScale = 1f;
        GameisPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BacktoMenuSettings()
    {
        pauseUI.SetActive(false);
        ButtonLeft.SetActive(true);
        ButtonRight.SetActive(true);
        Time.timeScale = 1f;
        GameisPaused = false;

    }

}
