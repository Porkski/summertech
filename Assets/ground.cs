using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ground : MonoBehaviour
{


    public Toggle Toggle;
    public GameObject groundt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void darkModeColors(){
    
        var groundR = groundt.GetComponent<Renderer>();

        if(Toggle.isOn==true){
        groundR.material.SetColor("_Color", Color.black);   
    }


    if(Toggle.isOn == false){
        groundR.material.SetColor("_Color", Color.white);   
    }


    }

    
}
