using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    
    private int timeWait = 1;
    private BoxCollider2D boxCollider2D;
    private bool canJump = true;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    Animator animator;
    private float t = 0.0f;
    private bool moving = false;
    //Animation moving = false;
    
    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();
        sprite = this.GetComponent<SpriteRenderer>();
        rb = this.GetComponent<Rigidbody2D>();
       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {

            Debug.Log("D is hit");
            rb.velocity = new Vector2(5.5f, rb.velocity.y);
            moving=true;
            t = 0.0f;
            if (sprite.flipX == true)
            {
                sprite.flipX = false;
            }



        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {

            Debug.Log("A is hit");
            rb.velocity = new Vector2(-5.5f, rb.velocity.y);
            moving = true;
            t = 0.0f;
            if (sprite.flipX == false)
            {
                sprite.flipX = true;
            }

        }

         if (Input.GetKey(KeyCode.Space) && canJump == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, 4.0f);
           StartCoroutine("wait1");// wait(timeWait);
            
        }

        if (Input.GetKey(KeyCode.Space) && canJump == false){
            rb.gravityScale = .27f;
        }
        else{
            rb.gravityScale = 1;
        }
        if (moving == true){
            
            animator.Play("Walk");
        }
        if (moving == false){
            animator.Play("Idleanim");
        }
        
       
       /* if (Input.GetKeyDown(KeyCode.D) && Input.GetKeyUp(KeyCode.A))
        {

            Debug.Log("bruv it worked 1");
            rb.velocity = new Vector2(5.5f, 0.0f);
            moving = true;
            t = 0.0f;
            if (sprite.flipX == true)
            {
                sprite.flipX = false;
            }



        }
         if (Input.GetKeyDown(KeyCode.A) && Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("bruh it has worked 2");
            rb.velocity = new Vector2(-5.5f, 0.0f);
            moving = true;
            t = 0.0f;
            if (sprite.flipX == false)
            {
                sprite.flipX = true;
            }
        }*/
        if (Input.GetKeyUp(KeyCode.A) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            Debug.Log("FREEZE 1");
            rb.velocity = new Vector2(0.0f, rb.velocity.y);
            moving=false;
        }
         if (Input.GetKeyUp(KeyCode.D) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            Debug.Log("FREEZE 2");
            rb.velocity = new Vector2(0.0f, rb.velocity.y);
            moving=false;
        }
        
    }
    void OnCollisionEnter2D(Collision2D call){
        canJump = true;
    }

    IEnumerator wait1() 
{
    yield return new WaitForSeconds(.02f);
    canJump = false;
}

}
