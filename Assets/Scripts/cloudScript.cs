using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudScript : MonoBehaviour
{
    private float _speed = 0.8f;
    private float _endPosX;
    int checkstart = 0;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("checkingforstart_cloud", 0);
        
    }

    public void startFloat(float speed , float endPosX)
    {
        _speed = speed;
        _endPosX = endPosX;
    }

    // Update is called once per frame
    void Update()
    {
        checkstart = PlayerPrefs.GetInt("checkingforstart_cloud", 0);
        transform.Translate(Vector3.right *( Time.deltaTime * _speed));
        //Debug.Log(checkstart);
        if (transform.position.x > _endPosX )
        {
            Destroy(gameObject);
                
        }
        if (checkstart == 1)
        {
            Destroy(gameObject);
        }

    }



}
