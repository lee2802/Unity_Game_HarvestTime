using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;
    private int checkboolean = 1;
    private int score, finalscore;
    private int scoreMultiply;
    private int checkbooleanforGameOver = 0;
    
    /*
    //Check boolean
    int boolToInt(bool val)
    {
        if (val)
            return 1;
        else
            return 0;
    }

    bool intToBool(int val)
    {
        if (val != 0)
            return true;
        else
            return false;
    }

    private bool isRestart = false;

    */

    // Update is called once per frame
    void Update()
    {
        
        scoreText.text = score.ToString();
        scoreMultiply = PlayerPrefs.GetInt("Multiplyer", 0); 

        if (PlayerPrefs.GetInt("CheckEndGame", 0) == checkboolean)
        {
            finalscore = score;
            PlayerPrefs.SetInt("CurrentScore", finalscore);
            PlayerPrefs.SetInt("CheckEndGame", 0);
            
            SceneManager.LoadScene("Gameover2.0");
        }
 

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        scoreMultiply = PlayerPrefs.GetInt("Multiplyer", 0);
        
        if (collision.tag == "bomb")
        {

            //1 is true, 0 = false
            Destroy(collision.gameObject);
            checkbooleanforGameOver = 1;
            //FindObjectOfType<audioManager>().Stop("bgm");
            //FindObjectOfType<audioManager>().Stop("collectsoundeffect");
            //FindObjectOfType<audioManager>().Play("gameover");
            PlayerPrefs.SetInt("CheckEndGame", checkbooleanforGameOver);


        }
        if (collision.tag == "fruits")
        {
            if (PlayerPrefs.GetInt("checkforfullstack", 0) == 0)
            {
                PlayerPrefs.SetInt("stackfever", 10);
            }
            // 1 is got combo 0 is non
            PlayerPrefs.SetInt("stackcombo", 1);
            PlayerPrefs.SetInt("addcombo", 1);
            Destroy(collision.gameObject);
            score += 50 * scoreMultiply;
            FindObjectOfType<audioManager>().Play("collectsoundeffect");
        }
        if (collision.tag == "veges")
        {
            if (PlayerPrefs.GetInt("checkforfullstack", 0) == 0)
            {
                PlayerPrefs.SetInt("stackfever", 10);
            }
            PlayerPrefs.SetInt("stackcombo", 1);
            PlayerPrefs.SetInt("addcombo", 1);
            Destroy(collision.gameObject);
            score += 50 * scoreMultiply;
            FindObjectOfType<audioManager>().Play("collectsoundeffect");
        }
        if (collision.tag == "dwarf")
        {
            if (PlayerPrefs.GetInt("checkforfullstack", 0) == 0)
            {
                PlayerPrefs.SetInt("stackfever", 20);
            }
            PlayerPrefs.SetInt("stackcombo", 1);
            PlayerPrefs.SetInt("addcombo", 1);
            Destroy(collision.gameObject);
            score += 200 * scoreMultiply;
            FindObjectOfType<audioManager>().Play("bonus");
        }


    }


}
