using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testCar : MonoBehaviour
{

    
    public float resistance;
    public float turnpower = 1;
    private Vector3 myVel;
    private Vector3 acceleration;
    private float maxSpeed = 0.1f;
    Vector3 position;
    // Start is called before the first frame update
    void Start()
    {

        myVel = new Vector3(0, 0, 0);
        acceleration = new Vector3(0, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            float currentspeed = myVel.magnitude;
            myVel.Normalize();
            transform.Translate(0, acceleration.y / resistance, 0);
            if (myVel.magnitude <= maxSpeed)
            {
                acceleration.y += 0.001f / resistance;
               
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            float currentspeed = myVel.magnitude;
            myVel.Normalize();
            transform.Translate(0, acceleration.y / resistance, 0);
            if (acceleration.y >= -2 * maxSpeed)
            {
                acceleration.y -= 0.001f /2  ;
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * turnpower);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward * -turnpower);
        }

    


        // transform.position += myVel;
        //UnityEngine.Debug.Log(transform.position.y);

        if (position.y > 25.15f)
        {
           position.y = -3.93f;
            transform.position = position;
        }

        if (position.x > 15.46f)
        {
            position.x = -4.19f;
            transform.position = position;
        }

        /*
        if ( position.y <= -2.86f && Input.GetKey(KeyCode.S) ) {
            acceleration.y = 0.0f;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            acceleration.y = 0.0f;
        }*/





        /* if (position.y <= -2.86)
         { acceleration.y = 0.0f; }*/


        // Yakıt bitince duracak
        Text TxtAccident = GameObject.Find("Canvas/miktar").GetComponent<Text>();
       // UnityEngine.Debug.Log(TxtAccident.text);
        if (float.Parse(TxtAccident.text) == 0)
        {
            acceleration.y = 0;
            turnpower = 0;
        }
        gas();
    }

    void gas()
    {
       
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {  
                if (acceleration.y >= 0 )
                {
                    transform.Translate(0, acceleration.y / resistance, 0);
                    acceleration.y -= 0.0005f / resistance;
                }
                else if (acceleration.y <= 0)
                {
                    transform.Translate(0, acceleration.y / resistance, 0);
                    acceleration.y += 0.0005f / resistance;
                }
            
           // UnityEngine.Debug.Log(acceleration.y);
        }
    }
}
