using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    public GameObject Heart2;
    private int i;
    
    void start()
    {
        i = 0;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player1")
        {
            i = 1;
        }
        if ((collision.gameObject.tag == "player2") & (i == 1))
        {
            Heart2.gameObject.SetActive(false);

            
        }
                
                  
        
            
        
    }
}
