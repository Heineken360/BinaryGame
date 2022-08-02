using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [Header("Player velocity")]
    public int xVelocity = 2;
    public int yVelocity = 2;
    [SerializeField]
    public  Rigidbody2D player1rb;
    public Rigidbody2D player2rb;
   

    void Start()
    {

    }
    private void Update()
    {
        updatePlayerPosition();
    }

    private void updatePlayerPosition()
    {

        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput == 0)
        {
            player1rb.velocity = new Vector2(0, 0);
            player2rb.velocity = new Vector2(0, 0);
        }
        if (horizontalInput > 0)
        {
            player1rb.velocity = new Vector2(xVelocity, 0);
            player2rb.velocity = new Vector2(-xVelocity, 0);
        }
        if (horizontalInput < 0)
        {
            player1rb.velocity = new Vector2(-xVelocity, 0);
            player2rb.velocity = new Vector3(xVelocity, 0);
        }
        if (verticalInput >0)
        {
            player1rb.velocity = new Vector2(0, yVelocity);
            player2rb.velocity = new Vector2(0, yVelocity);
        }
        if(verticalInput < 0)
        {
            player1rb.velocity = new Vector2(0, -yVelocity);
            player2rb.velocity = new Vector2(0, -yVelocity);
        }
    }
}
