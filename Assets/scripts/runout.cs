using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class runout : MonoBehaviour
{
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text TxtAccident = GameObject.Find("Canvas/miktar").GetComponent<Text>();
        // UnityEngine.Debug.Log(TxtAccident.text);
        if (float.Parse(TxtAccident.text) == 0)
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

      
    }
}
