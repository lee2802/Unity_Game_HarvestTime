using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class countdownScript : MonoBehaviour
{
    public int countdownTime;
    public TextMeshProUGUI number;
    [SerializeField]
    public GameObject[] todisable;

    public GameObject[] toenable;


    private void Start()
    {
        StartCoroutine(countdownTimer());
     
    }

    IEnumerator countdownTimer()
    {
        while (countdownTime > 0)
        {
            
            number.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);
            countdownTime--;
        }

        number.text = "Start!";
        yield return new WaitForSeconds(1f);

        foreach (GameObject gameobjects in todisable)
        {
            gameobjects.SetActive(false);
        }
        foreach (GameObject gameobjects in toenable)
        {
            gameobjects.SetActive(true);
        }

    }

}
