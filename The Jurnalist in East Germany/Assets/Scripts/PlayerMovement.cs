using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Rigidbody2D rigidBody2d;
    Vector3 playerScale;
    Animator animator;
    [SerializeField]
    private SpriteRenderer playerSprite;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2d = GetComponent <Rigidbody2D>();
        animator = GetComponent <Animator>();
        Vector3 playerScale = transform.localScale;

        GameManager.instance.checkButtonLayout();
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
            if(animator.GetBool("isInteract"))
                return;
            velocity.x += speed;
            animator.SetBool("isWalking",true);
            playerSprite.flipX = true;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(animator.GetBool("isInteract"))
                return;
            velocity.x -= speed;
            animator.SetBool("isWalking",true);
            playerSprite.flipX = false;
        }

        else
        {
            velocity.x = 0.0f;
            
            if(animator.GetBool("isInteract"))
                return;
            animator.SetBool("isWalking",false);
        }

        if(Input.GetKeyDown(KeyCode.Z))
        {
            animator.SetBool("isInteract",true);
            Debug.Log("Interaction State :"+animator.GetBool("isInteract"));
            StartCoroutine(finishInteract());
        }

        rigidBody2d.velocity += velocity;

    }

    private IEnumerator finishInteract(){
        for(int i =0; i < 2; i ++)
        {
            if(i == 1)
            {
                animator.SetBool("isInteract",false);
                Debug.Log("Interaction State :"+animator.GetBool("isInteract"));
            }
            yield return new WaitForSeconds(0.5f);
        }
        
        
        
    }

}
