using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformSpray : MonoBehaviour
{
    public GameObject SprayFabUp;
    public GameObject SprayFabDown;
    public GameObject SprayFabLeft;
    public GameObject SprayFabRight;

    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        

        if (Input.GetKeyUp(KeyCode.Space))
        {

            
            SprayFabUp.gameObject.SetActive(false);
            SprayFabDown.gameObject.SetActive(false);
            SprayFabLeft.gameObject.SetActive(false);
            SprayFabRight.gameObject.SetActive(false);
        }
         else if ((verticalInput > 0) && Input.GetKeyDown(KeyCode.Space))
        {
     
            SprayFabUp.gameObject.SetActive(true);
            SprayFabDown.gameObject.SetActive(false);
            SprayFabLeft.gameObject.SetActive(false);
            SprayFabRight.gameObject.SetActive(false);
        }
        else if((verticalInput <0) && Input.GetKeyDown(KeyCode.Space))
        {
           
            SprayFabDown.gameObject.SetActive(true);
            SprayFabUp.gameObject.SetActive(false);
            SprayFabLeft.gameObject.SetActive(false);
            SprayFabRight.gameObject.SetActive(false);
        }
        else if((horizontalInput > 0) && Input.GetKeyDown(KeyCode.Space))
        {
            
            SprayFabRight.gameObject.SetActive(true);
            SprayFabUp.gameObject.SetActive(false);
            SprayFabDown.gameObject.SetActive(false);
            SprayFabLeft.gameObject.SetActive(false);
        }
        else if((horizontalInput < 0) && Input.GetKeyDown(KeyCode.Space))
        {
           
            SprayFabLeft.gameObject.SetActive(true);
            SprayFabUp.gameObject.SetActive(false);
            SprayFabDown.gameObject.SetActive(false);
            SprayFabRight.gameObject.SetActive(false);


        }
        
    }
}
