using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Rigidbody2D rigidBody2d;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody2d = GetComponent <Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        platformMovement();
    }

    private void platformMovement()
    {
        Vector2 currentPosition = transform.position;
        Vector2 resetSpeed = new Vector2(0,currentPosition.y);
        rigidBody2d.velocity = resetSpeed;
        Vector2 velocity = rigidBody2d.velocity;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity.x += speed;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity.x -= speed;
        }

        else
        {
            velocity.x = 0.0f;
        }


        rigidBody2d.velocity += velocity;
    }

}
