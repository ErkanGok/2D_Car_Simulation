using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class carSpawnerA : MonoBehaviour
{
    public GameObject[] cars;
    int carNo;
    public float maxPos = 2.2f;
    public float delayTimer = 1f;
    float timer;
    Vector3 carPos;
    public Transform PlayerTransform;
    private Vector3 _cameraOffset;
    [Range(0.01f, 1.0f)]
    public float Smoothfactor = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;
        _cameraOffset = transform.position - PlayerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {            
                carPos = new Vector3(Random.Range(1.355f, 2.53f), transform.position.y, transform.position.z);
                carNo = Random.Range(0, 5);
                Instantiate(cars[carNo], carPos, transform.rotation);
                timer = delayTimer;        
      
        }
    }

    void LateUpdate()
    {
        Vector3 newPos = PlayerTransform.position + _cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, Smoothfactor);

    }
    

}
