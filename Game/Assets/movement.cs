﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 100f;
    void Start()
    {
     //   rb.AddForce(0,100,500);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d")){
            rb.AddForce(sidewaysForce * Time.deltaTime ,0,0);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-sidewaysForce * Time.deltaTime,0,0);
        }
        if(Input.GetKey("w")){
            rb.AddForce(0,0,sidewaysForce * Time.deltaTime);
        }
        if(Input.GetKey("s")){
            rb.AddForce(0,0, -sidewaysForce * Time.deltaTime);
        }
       // if(Input.GetKey()){
            
       // }
    }
}
