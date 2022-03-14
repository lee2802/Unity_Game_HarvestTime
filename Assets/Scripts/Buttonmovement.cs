using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Buttonmovement : MonoBehaviour
{
    private bool moveLeft;
    private bool moveRight;
    private float horizontalMove;
    private int speed;
    private int speedRate;
    private int isWindy;

    private int checkreverse; // 1 true 0 false
    private int checkFever;

    private int reducespeedrate;

    Rigidbody2D rb;

    public Vector2 nextPosLeft;
    public Vector2 nextPosRight;

    int randm;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveLeft = false;
        moveRight = false;
        speed = 4;
        rb.velocity = new Vector2(rb.position.x, rb.position.y);
        randm = Random.Range(1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
       movingPlayer();
        // speedRate if 3 then is winter 4 then is in fever mode winter
       speedRate = PlayerPrefs.GetInt("playermovement", 0);
       checkreverse = PlayerPrefs.GetInt("checkInverted", 0);
       isWindy = PlayerPrefs.GetInt("checkWindy", 0);
       checkFever = PlayerPrefs.GetInt("checkforfullstack", 0);
        if (speedRate == 3)  // winter rate
        {
            reducespeedrate = 2;
           
        }
        else
        {
            reducespeedrate = speedRate;
        }

    }

    public void ButtonDownLeft()
    {
        moveLeft = true;
    }

    public void ButtonUpLeft()
    {
        moveLeft = false;
    }


    public void ButtonDownRight()
    {
        moveRight = true;
    }

    public void ButtonUpRight()
    {
        moveRight = false;
    }

    private void movingPlayer()
    {
        // Check if in fever mode
        
        //Debug.Log(randm);
        if (checkFever == 1) //fever mode
        {
            // speed rate while fever
            int increasedspeed = speed * speed/2;
            //check if control is inverted
           // Debug.Log("Fever mode started");
            if (checkreverse == 1)
            {
                //Debug.Log("Fever Inverted");
                if (moveLeft)
                {
                    horizontalMove = increasedspeed * reducespeedrate / speedRate;

                }
                else if (moveRight)
                {
                    horizontalMove = -increasedspeed * reducespeedrate / speedRate;
                }
                else
                {
                    horizontalMove = 0;
                }
            }
            else if (isWindy == 1) // fever windy
            {
                // 1 is left, 2 is right
                
                if (randm == 1) // move to left automatically 
                {
                    horizontalMove = -increasedspeed * reducespeedrate / speedRate;
                    if (moveRight)
                    {
                        horizontalMove = increasedspeed * reducespeedrate / speedRate;
                    }
                }
                else// move to right automatically 
                {
                    horizontalMove = increasedspeed * reducespeedrate / speedRate;
                    if (moveLeft)
                    {
                        horizontalMove = -increasedspeed * reducespeedrate / speedRate;
                    }
                }
            }

            else
            {
                //Debug.Log("Normal fever");
                if (moveLeft)
                {
                    horizontalMove = -increasedspeed * reducespeedrate / speedRate;

                }
                else if (moveRight)
                {
                    horizontalMove = increasedspeed * reducespeedrate / speedRate;
                }
                else
                {
                    horizontalMove = 0;
                }
            }
        }
        else // not fever mode
            {
                int increasedspeed = speed;
                //check if control is inverted
                if (checkreverse == 1)  //inverted
                {
                   // Debug.Log("Inverted normal");
                    if (moveLeft)
                    {
                        horizontalMove = speed * reducespeedrate / speedRate;

                    }
                    else if (moveRight)
                    {
                        horizontalMove = -speed * reducespeedrate / speedRate;
                    }
                    else
                    {
                        horizontalMove = 0;
                    }
                }
                else if (isWindy == 1) // normal windy
                {
               
                if (randm == 1) // move to left automatically 
                {
                    horizontalMove = -increasedspeed * reducespeedrate / speedRate;
                    if (moveRight)
                    {
                        horizontalMove = increasedspeed * reducespeedrate / speedRate;
                    }
                }
                else // move to right automatically 
                {
                    horizontalMove = increasedspeed * reducespeedrate / speedRate;
                    if (moveLeft)
                    {
                        horizontalMove = -increasedspeed * reducespeedrate / speedRate;
                    }
                }

            }


                
                else
                {
                  //  Debug.Log("normal");
                    if (moveLeft)
                    {
                        horizontalMove = -speed * reducespeedrate / speedRate;

                    }
                    else if (moveRight)
                    {
                        horizontalMove = speed * reducespeedrate / speedRate;
                    }
                    else
                    {
                        horizontalMove = 0;
                    }
                }
            }
        }
    


    public void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }
}
