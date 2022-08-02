using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDestroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "spider")
        {
            Debug.Log("You Lose!");
        }
        if(collision.gameObject.tag == "spiderweb")
        {
            Debug.Log("You Lose!");
        }
    }
}
