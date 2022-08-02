using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;

    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "spiderweb")
        {
            Destroy(collision.gameObject);
            int score = int.Parse(scoreGT.text);
            score += 100;
            scoreGT.text = score.ToString();
            
        }
        if (collision.gameObject.tag == "spider")
        {
            Destroy(collision.gameObject);
            int score = int.Parse(scoreGT.text);
            score += 200;
            scoreGT.text = score.ToString();
        }
    }
}
