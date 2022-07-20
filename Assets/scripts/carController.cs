using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class carController : MonoBehaviour
{
    public float carSpeed;
    public float directionSpeed = 5.0f;
    public float maxPos = 2.001f;
    Vector3 position;
    Boolean left;
    Boolean right;
    Boolean up;
    Boolean down;
    Vector3 direction;
    
   


    // Start is called before the first frame update
    void Start()
    {
        left = true;
        right = true;
        up = true;
        down =  true;
        position = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = position;


        if (Input.GetKey(KeyCode.RightArrow) && right == true)
        {
            position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
            
        }

        if (Input.GetKey(KeyCode.LeftArrow) && left == true )
        {
            position.x -= Input.GetAxis("Horizontal") * carSpeed * -Time.deltaTime;           
        }

        if (Input.GetKey(KeyCode.UpArrow) && up == true )
        {
            position.y += Input.GetAxis("Vertical") * carSpeed * Time.deltaTime;           
        }        

        if (Input.GetKey(KeyCode.DownArrow) && down == true && position.y >= -2.89)
        {
            position.y -= Input.GetAxis("Vertical") * carSpeed * -Time.deltaTime;         
        }
        /*
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * directionSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward * -directionSpeed);
        }
        */


        /*
          if (position.y >= 7.59f && position.y <= 11.10f)
          {
              position.x = Mathf.Clamp(position.x, -0.5f, 3.61f);
          }

          if (position.x >= 2.55f && position.x <= 4.20f)
          {
              position.y = Mathf.Clamp(position.y, 7.56f, 10.16f);
          }*/

        /*
        if (position.y >= 7.59f && position.y <= 11.10f)
        { right = true; }*/








        /*
        if (position.x > -0.51f)
        {
            left = true;
        }

        if (position.y >=7.57 && position.y <=10.15)
        {
            right = true;
        }*/













        if (position.y > 24)
        {
            position.y = -2;
        }
        
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "solserit" && Input.GetKey(KeyCode.LeftArrow))
        {
            left = false;

           // UnityEngine.Debug.Log("çarpıştım");
        }
        
        if (col.gameObject.tag == "sagserit" && Input.GetKey(KeyCode.RightArrow) )
        {
            right = false;

            // UnityEngine.Debug.Log("çarpıştım");
        }
        
        if (col.gameObject.tag == "sagyan" && Input.GetKey(KeyCode.DownArrow))
        {
            down = false;

            // UnityEngine.Debug.Log("çarpıştım");
        }
        
        if (col.gameObject.tag == "sagyan" && Input.GetKey(KeyCode.UpArrow))
        {
            up = false;

            // UnityEngine.Debug.Log("çarpıştım");
        }
        



    }

    void OnCollisionExit2D(Collision2D col)
    {

        left = true;
        right = true;
        down = true;
        up = true;
        
        /*
        if (col.gameObject.tag == "solserit" && Input.GetKey(KeyCode.RightArrow))
        {
            left = true;

            //UnityEngine.Debug.Log("çarpışmayı bıraktım");
        }

        if (col.gameObject.tag == "sagserit" && Input.GetKey(KeyCode.LeftArrow) )
        {
            right = true;

         //   UnityEngine.Debug.Log("çarpışmayı bıraktım");
        }

        if (col.gameObject.tag == "sagserit" && Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.UpArrow))
        {
            down = true;

            //   UnityEngine.Debug.Log("çarpışmayı bıraktım");
        }

        if (col.gameObject.tag == "sagserit" && Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            up = true;

            //   UnityEngine.Debug.Log("çarpışmayı bıraktım");
        }*/


    }





    /*
    if (col.gameObject.tag == "solserit" && Input.GetKey(KeyCode.RightArrow))
    {
        left = true;
    }

    if (col.gameObject.tag == "sagserit" && Input.GetKey(KeyCode.RightArrow))
    {
        right = false;            
    } 

    /*
    if (col.gameObject.tag == "sagserit" && Input.GetKey(KeyCode.DownArrow))
    {
        down = false;
    }




}*/

}
