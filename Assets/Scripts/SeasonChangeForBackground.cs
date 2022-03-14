using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeasonChangeForBackground : MonoBehaviour
{
    public GameObject[] seasons;
    public GameObject startseason;
    public float xPos, yPos;
    private FadeIn fadein;
    private FadeOut fadeout;
    private SpriteRenderer sr;
    private int randomNum;
    // Start is called before the first frame update
    void Start()
    {
        
        startseason = Instantiate(seasons[0], new Vector2(xPos, yPos), Quaternion.identity);
       
        PlayerPrefs.SetInt("BuffsForSeason", 0);
        StartCoroutine(ChangeSeasons());
        
    }



    IEnumerator ChangeSeasons()
    {
        randomNum = Random.Range(8, 10);
        int randomSeason = Random.Range(0, seasons.Length);

        yield return new WaitForSeconds(randomNum);

 
        PlayerPrefs.SetInt("BuffsForSeason",randomSeason);
        DestroyBG(startseason);

  

        startseason = Instantiate(seasons[randomSeason], new Vector2(xPos, yPos), Quaternion.identity);
        sr = startseason.GetComponent<SpriteRenderer>();
       
        Color c = sr.material.color;
        c.a = 0f;
        sr.material.color = c;
        
        StartCoroutine("Fadein");
        StartCoroutine(ChangeSeasons());


    }

    void DestroyBG(GameObject gameobj)
    {
        Destroy(gameobj.gameObject);
    }



    IEnumerator Fadein()
    {
        for (float f = 0.05f; f <= 1f; f += 0.05f)
        {
            Color c = sr.material.color;
            c.a = f;
            sr.material.color = c;
            yield return new WaitForSeconds(0.05f);
        }
    }
}
