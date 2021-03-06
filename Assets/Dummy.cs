using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{
    AudioSource audioData;
    Animator animator;
public int hp = 3;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
         animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hp<1 && !animator.GetCurrentAnimatorStateInfo(0).IsName("dummydeath")){
            audioData.Play(0);
            animator.Play("dummydeath");
        }

        if(animator.GetCurrentAnimatorStateInfo(0).IsName("death")){
            Destroy(this.gameObject);
        }
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("back")){

            animator.Play("New State");
        }
    }

    void OnTriggerEnter2D(Collider2D call){
        if(call.gameObject.tag == "Proj"){
            hp = hp-1;
            audioData.Play(0);
            animator.Play("dummydamage");
            
        }

    }



}
