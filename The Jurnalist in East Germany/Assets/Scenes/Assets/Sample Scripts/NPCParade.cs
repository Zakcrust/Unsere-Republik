using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCParade : MonoBehaviour
{
    public Text text;
    public string displayText;
    public GameObject interactLayout;
    Rigidbody2D rigidbody2D;
    Animator animator;
    private IEnumerator coroutine;
    public SpriteRenderer NPCSprite;
    Vector2 speed;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        NPCSprite.flipX = true;
        speed = new Vector2(1,0);
        rigidbody2D.velocity = speed;
        coroutine   = TurnAfter(3);
        StartCoroutine(coroutine);
        
    }

    IEnumerator TurnAfter(float time)
    {
        for(;;)
        {
            NPCSprite.flipX = !NPCSprite.flipX;
            speed.x *= -1;
            rigidbody2D.velocity = speed;
            yield return new WaitForSeconds(time);
        }
    }
}
