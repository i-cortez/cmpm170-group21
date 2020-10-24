// PlayerController.cs
//
// Group 21 Programming Team
// 10-20-2020
// This is a script that controls the player(s) movements
//
// Adapted from James at:
// https://www.youtube.com/watch?v=p23J5-1OTAM&list=PLiyfvmtjWC_Ugm9c9Q7WaoRFGBZh_Z6ys
//

using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public float moveSpeed;
   public float jumpForce;
   public KeyCode left;
   public KeyCode right;
   public KeyCode jump;
   public KeyCode throwBall;

   private Rigidbody2D theRB;
   public Transform groundCheckPoint;
   public bool isGrounded;
   public float groundCheckRadius;
   public LayerMask whatIsGround;
    // Start is called before the first frame update
    void Start()
    {
      theRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, whatIsGround);
      if(Input.GetKey(left))
      {
         theRB.velocity = new Vector2(-moveSpeed, theRB.velocity.y);
      }
      else if(Input.GetKey(right))
      {
         theRB.velocity = new Vector2(moveSpeed, theRB.velocity.y);
      }
      else
      {
         theRB.velocity = new Vector2(0, theRB.velocity.y);
      }

      if(Input.GetKeyDown(jump) && isGrounded)
      {
         theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
      }
    }
}

