using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject button;

    private bool canShoot = true;
    Rigidbody2D rb;
    public GameObject proj;
    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("Torture Dummy");
             }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButton(0) && canShoot == true && button.GetComponent<ButtonScript>().pressed==false){
            GameObject newProj = Instantiate(proj);
            rb = newProj.GetComponent<Rigidbody2D>();

            newProj.transform.position = this.transform.position;

            Vector2 tempV = UnityEngine.Camera.main.ScreenToWorldPoint(Input.mousePosition)-this.transform.position;
            tempV= Vector2.Scale(tempV, new Vector2(1000,1000));
            tempV =Vector2.ClampMagnitude(tempV,9.5f);

            rb.velocity = tempV;
            

            
            float angle = Mathf.Atan2(rb.velocity.y,rb.velocity.x) * Mathf.Rad2Deg;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            newProj.transform.rotation = q;


            canShoot=false;
            StartCoroutine("wait1");
        }

        
        
        
    }
    IEnumerator wait1() 
{
    yield return new WaitForSeconds(.3f);
    canShoot=true;
    
}
}
