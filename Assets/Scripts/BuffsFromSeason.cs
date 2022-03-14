using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffsFromSeason : MonoBehaviour
{

   
    private int checkNumber;

    private int checkFever;


    /*
     * spring = Double score
     * summer = reversed control
     * autumn = windy
     * winter = slowness
     *
     * Multiply 1 or 2
     * Playermovement 1 or 2
     * checkInverted 1 true 0 false
     * checkWindy 1 true 0 false
     */

    void Update()
    {

        checkNumber = PlayerPrefs.GetInt("BuffsForSeason", 0);
        checkFever = PlayerPrefs.GetInt("checkforfullstack", 0);
        switch (checkNumber)
        {
            case 0:  //spring
                if (checkFever == 1)
                {
                    PlayerPrefs.SetInt("Multiplyer", 2);
                    PlayerPrefs.SetInt("playermovement", 2);
                    PlayerPrefs.SetInt("checkInverted", 0);
                    PlayerPrefs.SetInt("checkWindy", 0);
                    PlayerPrefs.SetInt("increaseddroprate", 1);
                }
                else
                {
                    PlayerPrefs.SetInt("Multiplyer", 1);
                    PlayerPrefs.SetInt("playermovement", 1);
                    PlayerPrefs.SetInt("checkInverted", 0);
                    PlayerPrefs.SetInt("checkWindy", 0);
                    PlayerPrefs.SetInt("increaseddroprate", 1);
                }

                break;

            case 1:  //summer
                if (checkFever == 1)
                {
                    PlayerPrefs.SetInt("Multiplyer", 2);
                    PlayerPrefs.SetInt("playermovement", 2);
                    PlayerPrefs.SetInt("checkInverted", 1);
                    PlayerPrefs.SetInt("checkWindy", 0);
                    PlayerPrefs.SetInt("increaseddroprate", 1);
                }
                else
                {
                    PlayerPrefs.SetInt("Multiplyer", 1);
                    PlayerPrefs.SetInt("playermovement", 1);
                    PlayerPrefs.SetInt("checkInverted", 1);
                    PlayerPrefs.SetInt("checkWindy", 0);
                    PlayerPrefs.SetInt("increaseddroprate", 0);
                }
                break;

            case 2:  //Autumn
                if (checkFever ==1)
                {
                    PlayerPrefs.SetInt("Multiplyer", 2);
                    PlayerPrefs.SetInt("playermovement", 2);
                    PlayerPrefs.SetInt("checkInverted", 0);
                    PlayerPrefs.SetInt("checkWindy", 1);
                    PlayerPrefs.SetInt("increaseddroprate", 1);
                }
                else
                {
                    PlayerPrefs.SetInt("Multiplyer", 1);
                    PlayerPrefs.SetInt("playermovement", 1);
                    PlayerPrefs.SetInt("checkInverted", 0);
                    PlayerPrefs.SetInt("checkWindy", 1);
                    PlayerPrefs.SetInt("increaseddroprate", 0);
                }

                break;

            case 3: //Winter
                if (checkFever == 1)
                {
                    PlayerPrefs.SetInt("Multiplyer", 2);
                    PlayerPrefs.SetInt("playermovement", 4);
                    PlayerPrefs.SetInt("checkInverted", 0);
                    PlayerPrefs.SetInt("checkWindy", 0);
                    PlayerPrefs.SetInt("increaseddroprate", 1);
                }
                else
                {
                    PlayerPrefs.SetInt("Multiplyer", 1);
                    PlayerPrefs.SetInt("playermovement", 3);
                    PlayerPrefs.SetInt("checkInverted", 0);
                    PlayerPrefs.SetInt("checkWindy", 0);
                    PlayerPrefs.SetInt("increaseddroprate", 0);
                }

                break;

        }
    }
}
