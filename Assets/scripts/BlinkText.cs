using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkText : MonoBehaviour
{
    public float timer;
    public Transform PlayerTransform;

    void Start()
    {
        GetComponent<Text>().enabled = false;

    }


    void Update()
    {
        //UnityEngine.Debug.Log(PlayerTransform.transform.rotation.eulerAngles.z);

        if (PlayerTransform.position.x >=-0.49f && PlayerTransform.position.x <= 1.01f && PlayerTransform.transform.rotation.eulerAngles.z < 90 || PlayerTransform.position.x >= -0.49f && PlayerTransform.position.x <= 1.01f && PlayerTransform.transform.rotation.eulerAngles.z > 270) 
        {

            timer = timer + Time.deltaTime;
            if (timer >= 0.5)
            {
                GetComponent<Text>().enabled = true;
            }
            if (timer >= 1)
            {
                GetComponent<Text>().enabled = false;
                timer = 0;
            }
        }
        else if (PlayerTransform.position.x >= 1.01f && PlayerTransform.position.x <= 2.55f && PlayerTransform.transform.rotation.eulerAngles.z > 90 && PlayerTransform.transform.rotation.eulerAngles.z < 270)
        {

            timer = timer + Time.deltaTime;
            if (timer >= 0.5)
            {
                GetComponent<Text>().enabled = true;
            }
            if (timer >= 1)
            {
                GetComponent<Text>().enabled = false;
                timer = 0;
            }
        }
        else
        {
            GetComponent<Text>().enabled = false;
        }
        

        //=================================================================================



    }

}

