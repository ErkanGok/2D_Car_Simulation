using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class MaincameraMove : MonoBehaviour
{    
    public Transform PlayerTransform;    
    private Vector3 _cameraOffset;
    [Range(0.01f, 1.0f)]
    public float Smoothfactor = 0.5f; 
    


    // Start is called before the first frame update
    void Start()
    {
        _cameraOffset = transform.position - PlayerTransform.position;
        
    }

    // Update is called once per 
    void LateUpdate()
    {
        Vector3 newPos = PlayerTransform.position + _cameraOffset;

        /*if (newPos.y >= 0.12f && newPos.y < 21.15f)
        {
           newPos.x = 0;
            transform.position = Vector3.Slerp(transform.position, newPos, Smoothfactor);

            if (newPos.x > 0.0f && newPos.x <= 9.29f)
            {
                transform.position = Vector3.Slerp(transform.position, newPos, Smoothfactor);
            }
        }      */
        /*transform.position = Vector3.Slerp(transform.position, newPos, Smoothfactor);
        UnityEngine.Debug.Log(newPos.x);*/

        /* if (PlayerTransform.position.x <= 2.6f && PlayerTransform.position.x >= -0.50)
         {
                newPos.x = 0.0f;
         }
         else        
         {
             transform.position = Vector3.Slerp(transform.position, newPos, Smoothfactor);
         }*/
        /*
         if (newPos.y >= 0.12f && newPos.y <= 21.15f && newPos.x >= 1.94f && newPos.x <= )
            {
                transform.position = Vector3.Slerp(transform.position, newPos, Smoothfactor);
            }*/

        
        /*
        if (newPos.y >= 0.12f && newPos.y <= 21.11f)
        {
            if (newPos.x <= 0.0f)
            {
                newPos.x = 0.0f;
                transform.position = Vector3.Slerp(transform.position, newPos, Smoothfactor);
            }
            //transform.position = Vector3.Slerp(transform.position, newPos, Smoothfactor);
        }*/

        if (newPos.y < 0.12f)
        {
            newPos.y = 0.12f;
        } 
        if (newPos.y > 21.11f)
        {
            newPos.y = 21.11f;
        } 
        if (newPos.x < 0.0f)
        {
            newPos.x = 0.0f;
        }
        if (newPos.x > 9.29f)
        {
            newPos.x = 9.29f;
        } 
        
            transform.position = Vector3.Slerp(transform.position, newPos, Smoothfactor);
        









       // UnityEngine.Debug.Log(newPos.y);
        /*
        if ()
           {
               transform.position = Vector3.Slerp(transform.position, newPos, Smoothfactor);
           }*/




        //transform.position = Vector3.Slerp(transform.position, newPos, Smoothfactor);

        //UnityEngine.Debug.Log(newPos.x);

    }

}
