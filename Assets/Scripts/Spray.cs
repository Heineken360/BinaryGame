using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spray : MonoBehaviour
{

    public GameObject sprayPref;

    void Start()
    {
        sprayPref.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sprayPref.gameObject.SetActive(true);
            //transform.Rotate(Vector2.left);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            sprayPref.gameObject.SetActive(false);
        }
    }
}
