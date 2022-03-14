using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject mainbuttons;
    public GameObject bg_1;
    public GameObject bg_2;

    // Start is called before the first frame update
    [SerializeField]
    private GameObject button1;
    [SerializeField]
    private GameObject button2;
    [SerializeField]
    private GameObject button3;
    [SerializeField]
    private GameObject button4;
    [SerializeField]
    private GameObject button5;
    [SerializeField]
    private GameObject button6;
    [SerializeField]
    private GameObject button7;

    public void returntoMain()
    {
        tutorial.SetActive(false);
        mainbuttons.SetActive(true);
        bg_1.SetActive(true);
        bg_2.SetActive(true);
       
    }

    public void toPage1()
    {
        button1.SetActive(true);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
        button5.SetActive(false);
        button6.SetActive(false);
        button7.SetActive(false);
    }
    public void toPage2()
    {
        button1.SetActive(false);
        button2.SetActive(true);
        button3.SetActive(false);
        button4.SetActive(false);
        button5.SetActive(false);
        button6.SetActive(false);
        button7.SetActive(false);
    }
    public void toPage3()
    {
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(true);
        button4.SetActive(false);
        button5.SetActive(false);
        button6.SetActive(false);
        button7.SetActive(false);
    }
    public void toPage4()
    {
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(true);
        button5.SetActive(false);
        button6.SetActive(false);
        button7.SetActive(false);
    }
    public void toPage5()
    {
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
        button5.SetActive(true);
        button6.SetActive(false);
        button7.SetActive(false);
    }
    public void toPage6()
    {
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
        button5.SetActive(false);
        button6.SetActive(true);
        button7.SetActive(false);
    }
    public void toPage7()
    {
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
        button5.SetActive(false);
        button6.SetActive(false);
        button7.SetActive(true);
    }
}
