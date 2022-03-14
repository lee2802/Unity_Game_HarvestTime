using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cloudgeneratorScript : MonoBehaviour
{
    [SerializeField]
    GameObject[] clouds;
    [SerializeField]
    float spawnInterval;
    [SerializeField]
    GameObject endpoint;

    Vector3 startPos;


    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("checkingforstart_cloud", 0);
        startPos = transform.position;
        prewarm();
        Invoke("AttemptSpawn", spawnInterval);
    }


    void spawnCloud(Vector3 startPos)
    {

        GameObject cloud = Instantiate(clouds[Random.Range(0,clouds.Length)]);

        startPos.y = Random.Range(startPos.y - 2f, startPos.y + 2f);
        cloud.transform.position = new Vector3(startPos.x,startPos.y,startPos.z);

        float scale = Random.Range(0.2f,0.4f);
        cloud.transform.localScale = new Vector2(scale,scale);

        float speed = Random.Range(0.5f,1.5f);

        cloud.GetComponent<cloudScript>().startFloat(Random.Range(0.5f, 1.5f), endpoint.transform.position.x);


    }

    // To make checkups
    void AttemptSpawn()
    {
        spawnCloud(startPos);
        Invoke("AttemptSpawn", spawnInterval);
        Debug.Log("spawning");
    }

    void prewarm()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPos = startPos + Vector3.right * (i * 2);
            spawnCloud(spawnPos);
        }
    
    }


}
