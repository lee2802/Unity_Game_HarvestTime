using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComboScript : MonoBehaviour
{

    public TextMeshProUGUI combotext;
    private int combo;
    // checkcombo if 1 true 0 false
    private int checkcombo;
    private int addcombo;
    public GameObject combosystem;

    // Start is called before the first frame update
    void Start()
    {
        combo = 0;
        combosystem.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        checkcombo = PlayerPrefs.GetInt("stackcombo", 0);
        if (checkcombo == 1)
        {
            combosystem.SetActive(true);
            combocounting();


        }
        else if (checkcombo == 0)
        {
            combosystem.SetActive(false);
            combo = 0;
        }
        combotext.text = combo.ToString();
       
    }

    private void combocounting()
    {
        addcombo = PlayerPrefs.GetInt("addcombo", 0);
        if (addcombo == 1)
        {
            combo++;
            PlayerPrefs.SetInt("addcombo", 0);
        }
       
        //PlayerPrefs.SetInt("stackcombo", 0);
    }
}
