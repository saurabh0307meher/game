using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    void Update()
    {
        //First person view
        //transform.position = player.position;
        
        //3d view 
        transform.position = player.position + offset;
    }
}
