using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Fever : MonoBehaviour
{
    // score point used in this class is to act as value to calculate the gauge status

    private float scorePoint;

    [SerializeField]
    private Image imagefilling;

    public TextMeshProUGUI fevertext;

    private float currentscore;
    private float fevermode = 100;



    void Start()
    {
        scorePoint = PlayerPrefs.GetInt("stackfever", 0);
        PlayerPrefs.SetInt("checkforfullstack", 0);
        imagefilling.fillAmount = 0f;
        fevertext.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        scorePoint = PlayerPrefs.GetInt("stackfever", 0);

        if (PlayerPrefs.GetInt("checkforfullstack", 0) == 0)
        {
            startAccumulate();
        }
        
        // 1 for full stack, 0 or not full stack
        

    }

    private void startAccumulate()
    {
        currentscore += scorePoint;

        imagefilling.fillAmount += (scorePoint / fevermode);

        if (currentscore == fevermode)
        {
            FindObjectOfType<audioManager>().Play("fever");
            PlayerPrefs.SetInt("checkforfullstack", 1);
           
            StartCoroutine("startfevemode");
            PlayerPrefs.SetInt("stackfever", 0);
        }
        else
        {
            PlayerPrefs.SetInt("stackfever", 0);
        }
        

    }



    private IEnumerator startfevemode()
    {
        
        fevertext.enabled = true;


        while (imagefilling.fillAmount > 0f)
        {
            //currentscore -= 10 * Time.deltaTime;

            imagefilling.fillAmount -= (10 / fevermode);
       
            yield return new WaitForSeconds(1f);

        }
        resetstack();

    }

    private void resetstack()
    {
        PlayerPrefs.SetInt("checkforfullstack", 0);
        currentscore = 0;
        fevertext.enabled = false;
        StopCoroutine("startfevemode");


    }
}
