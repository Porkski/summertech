using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Fireball : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
        //transform.rotation = Quaternion.LookRotation(directionVector);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Death")){
                Destroy(this.gameObject);
        }
    }


    void OnTriggerEnter2D(Collider2D call){
         if(call.gameObject.tag != "Player"){

        
        animator.Play("exploding");
        
         }

       
    }
}
