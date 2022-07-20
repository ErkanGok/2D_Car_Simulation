using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class refueling : MonoBehaviour
{
    public Transform PlayerTransform;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerTransform.position.x >= 2.5f && PlayerTransform.position.x <= 4.3f && PlayerTransform.position.y <= 11.14f && PlayerTransform.position.y >= 6.52f || PlayerTransform.position.x >= -2.17f && PlayerTransform.position.x <= -0.51f && PlayerTransform.position.y <= 14.58f && PlayerTransform.position.y >= 9.99f)
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
        } else
        {
            GetComponent<Text>().enabled = false;
        }
        

    }
}
