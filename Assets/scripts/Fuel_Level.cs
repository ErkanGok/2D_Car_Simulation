using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Fuel_Level : MonoBehaviour
{
    public float timer;
    public Transform PlayerTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //timer = timer + Time.deltaTime;
        float number = 100f;

        if (Input.GetKey(KeyCode.W) && float.Parse(GetComponent<Text>().text) != 0.0 || Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.E) && float.Parse(GetComponent<Text>().text) != 0.0)
        {
            number = float.Parse(GetComponent<Text>().text);
            number -= Time.deltaTime;
            GetComponent<Text>().text = number.ToString("0.00");
        }
       
        if (Input.GetKey(KeyCode.E) && float.Parse(GetComponent<Text>().text) < 100 && PlayerTransform.position.x >= 3.15f && PlayerTransform.position.x <= 3.67f || Input.GetKey(KeyCode.E) && float.Parse(GetComponent<Text>().text) < 100 && PlayerTransform.position.x >= -1.61f && PlayerTransform.position.x <= -1.14f)
        {
            number = float.Parse(GetComponent<Text>().text);
            number += Time.deltaTime;
            GetComponent<Text>().text = number.ToString("0.00");
        }

        if (Input.GetKey(KeyCode.E) && float.Parse(GetComponent<Text>().text) == 100.00f)
        {
            Text TxtAccident = GameObject.Find("Canvas/refueling").GetComponent<Text>();
            TxtAccident.text = "Fuel is Full !";
        } else
        {
            Text TxtAccident = GameObject.Find("Canvas/refueling").GetComponent<Text>();
            TxtAccident.text = "Press 'E' for refueling";
        }

        // UnityEngine.Debug.Log(float.Parse(GetComponent<Text>().text));



        
        if (Input.GetKey(KeyCode.R) && float.Parse(GetComponent<Text>().text) == 0.00f)
        {
            Time.timeScale = 1;
            Application.LoadLevel("level1");
        }

     

    }
  
}
