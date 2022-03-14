using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject mainbuttons;
    public GameObject bg_1;
    public GameObject bg_2;
   
    void Start()
    {
        Time.timeScale = 1f;
    }


    public void ExitButton()
    {
        //FindObjectOfType<audioManager>().Stop("mainmenumusic");
        Application.Quit();
        //Debug.Log("Exit Closed");
    }
    /**
    public void StartGame()
    {

        
       // FindObjectOfType<audioManager>().Play("bgm");
       // FindObjectOfType<audioManager>().Play("collectsoundeffect");
        //FindObjectOfType<audioManager>().Stop("mainmenumusic");
        PlayerPrefs.SetInt("CheckEndGame", 0);
        SceneManager.LoadScene("Prototype_1.0");
        
    }


    public void MainMenu()
    {
       // FindObjectOfType<audioManager>().Stop("bgm");
        //FindObjectOfType<audioManager>().Stop("collectsoundeffect");
       // FindObjectOfType<audioManager>().Play("mainmenumusic");
      //  FindObjectOfType<audioManager>().Stop("gameover");
        SceneManager.LoadScene("MainMenu2.0");
    }
    */
    public void Tutorial()
    {
        tutorial.SetActive(true);
        mainbuttons.SetActive(false);
        bg_1.SetActive(false);
        bg_2.SetActive(false);
    }


    public void disablecloud()
    {
        PlayerPrefs.SetInt("checkingforstart_cloud", 1);
    }
    public void enablecloud()
    {
        PlayerPrefs.SetInt("checkingforstart_cloud", 0);
    }

}
