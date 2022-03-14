using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text highscoretext;
    public Text currentscoretext;
    // Start is called before the first frame update

    private int highscore;
    private int currentscore;

    /*
    //check boolean

    bool intToBool(int val)
    {
        if (val != 0)
            return true;
        else
            return false;
    }

    private bool checkRestart = false;

    */
    void Start()
    {
        //checkRestart = intToBool(PlayerPrefs.GetInt("CheckBoolForRestart", 0));

        currentscore = PlayerPrefs.GetInt("CurrentScore", 0);
        currentscoretext.text = PlayerPrefs.GetInt("CurrentScore", 0).ToString();
        highscore = PlayerPrefs.GetInt("Highscore", 0);
        if (currentscore > highscore)
        {
            highscore = currentscore;
            PlayerPrefs.SetInt("Highscore", highscore);
            highscoretext.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
        }
        else
        {
            highscoretext.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
        }
        
    }




}
