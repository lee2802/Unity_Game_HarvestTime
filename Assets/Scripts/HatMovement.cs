using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System;

public class HatMovement : MonoBehaviour
{
    private Rigidbody2D myBody;

    private int slowsplayerspeed;
    public float speed, xBoundleft, xBoundright;
    private int checkLeft;
    private int checkright;
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     
        // For moving with keyboards
        float h = Input.GetAxisRaw("Horizontal");
        slowsplayerspeed = PlayerPrefs.GetInt("playermovement",0);
        checkLeft = PlayerPrefs.GetInt("movetoleft", 0); 



        if (h>0 || checkright ==1)
        {
            myBody.velocity = Vector2.right * speed / slowsplayerspeed;
            checkright = 0;
        }
        else if (h< 0 || checkLeft == 1)
        {
            myBody.velocity = Vector2.left * speed / slowsplayerspeed;
            checkLeft = 0;
        }
        else
        {
            myBody.velocity = Vector2.zero;
        }
        
        transform.position = new Vector2(Mathf.Clamp(transform.position.x,-xBoundleft, xBoundright), transform.position.y);

        /*
          //For touch screen
          slowsplayerspeed = PlayerPrefs.GetInt("playermovement", 0);
          GoLeftorRight = PlayerPrefs.GetInt("GotoDirection", 2); 

          if (GoLeftorRight == 1)
          {
              myBody.velocity = Vector2.right * speed / slowsplayerspeed;
          }
          else if (GoLeftorRight == 0)
          {
              myBody.velocity = Vector2.left * speed / slowsplayerspeed;
          }
          else
          {
              myBody.velocity = Vector2.zero;
          }

          transform.position = new Vector2(Mathf.Clamp(transform.position.x, -xBound, xBound), transform.position.y);
       */
    }




}
