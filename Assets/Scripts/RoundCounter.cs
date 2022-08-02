using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RoundCounter : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text roundGT;

    void Start()
    {
        GameObject roundGO = GameObject.Find("RoundCounter");
        roundGT = roundGO.GetComponent<Text>();
        int round = SceneManager.GetActiveScene().buildIndex + 1;
        roundGT.text = round.ToString();
    }

}
