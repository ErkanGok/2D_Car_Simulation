using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyCar : MonoBehaviour
{
    public float speed = 3.0f;
    Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);

        

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        int number = 0;
        Text TxtAccident = GameObject.Find("Canvas/Number").GetComponent<Text>();
        if (col.gameObject.tag == "Player")
        {
            number = int.Parse(TxtAccident.text);
            number += 1;
            TxtAccident.text = number.ToString();
        }

        if (col.gameObject.tag == "Enemy Car")
        {
            Destroy(gameObject);
        }      
    }
}
