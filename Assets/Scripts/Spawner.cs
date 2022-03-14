using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject[] fruits;
    public GameObject bug;
    public GameObject dwarf;
    public float timenow;
    private int increasedrop;
    public float xBound,xBoundEnd, yBound;

    private int dropRateRangeDivision;
    // Start is called before the first frame update
    void Start()
    {
        timenow = 0;
        FindObjectOfType<audioManager>().Play("bgm");
      
        StartCoroutine(spawnRandomObjectwithoutbug());
    }

    void Update()
    {
        increasedrop = PlayerPrefs.GetInt("increaseddroprate", 0);
    }

    IEnumerator spawnRandomObject()
    {
        if (increasedrop ==1)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(0.4f, 0.6f));
        }
        else
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(0.7f, 1));
        }
        
        
        int randomFruits = UnityEngine.Random.Range(0, fruits.Length);

        const float SuperRarepercent = 1f / 10f;

        if (UnityEngine.Random.value >= SuperRarepercent)
        {
            Instantiate(fruits[randomFruits],
                new Vector2(UnityEngine.Random.Range(xBound, xBoundEnd),yBound),Quaternion.identity);
        }
        else if(UnityEngine.Random.value < SuperRarepercent)
        {
            Instantiate(dwarf,
                new Vector2(UnityEngine.Random.Range(xBound, xBoundEnd), yBound), Quaternion.identity);
        }
        else
        {
            Instantiate(bug,
               new Vector2(UnityEngine.Random.Range(xBound, xBoundEnd), yBound), Quaternion.identity);
        }



        StartCoroutine(spawnRandomObject());
    }

    IEnumerator spawnRandomObjectwithoutbug()
    {
        if (increasedrop == 1)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(0.4f, 0.6f));
        }
        else
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(0.7f, 1));
        }


        int randomFruits = UnityEngine.Random.Range(0, fruits.Length);

        const float SuperRarepercent = 1f / 10f;

        if (UnityEngine.Random.value >= SuperRarepercent)
        {
            Instantiate(fruits[randomFruits],
                new Vector2(UnityEngine.Random.Range(xBound, xBoundEnd), yBound), Quaternion.identity);
        }
        else if (UnityEngine.Random.value < SuperRarepercent)
        {
            Instantiate(dwarf,
                new Vector2(UnityEngine.Random.Range(xBound, xBoundEnd), yBound), Quaternion.identity);
        }

        timenow = timenow + Time.deltaTime;

        //int time = (int)Mathf.Round(timenow);

        //Debug.Log(timenow);
        
        if (timenow > 0.15)
        {
            StopCoroutine(spawnRandomObjectwithoutbug());
            StartCoroutine(spawnRandomObject());
            
        }
        else
        {
            StartCoroutine(spawnRandomObjectwithoutbug());
        }
       
    }
}
