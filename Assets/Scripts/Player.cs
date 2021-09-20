using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        DoJump();
        DoMove();

        void DoJump()
        {
            Vector2 velocity = rb.velocity;

            if (Input.GetKey("j"))
            {
                print("jump");

                if (velocity.y < 0.01f)
                {
                    velocity.y = 24f;
                }
            }
            rb.velocity = velocity;
        }

        void.DoMove()
            {
                Vector2 velocity = rb.velocity

                if (Input.GetKey("z"))
                {
                    velocity.x = -10;
                }

                if (Input.GetKey("x"))
                {
                    velocity.x = 10;
                }
            }
  
  
    }   
}
