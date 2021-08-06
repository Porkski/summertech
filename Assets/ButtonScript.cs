using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonScript : MonoBehaviour
{
    public bool pressed = false;
    // Start is called before the first frame update

    public void press(){
        pressed = true;
    }
     public void depress(){
        pressed = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
        


    }

    public void OnClick(){

    }

    
}
