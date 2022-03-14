using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision)
        {
            PlayerPrefs.SetInt("stackcombo", 0);
            Destroy(collision.gameObject);
        }
    }
}
