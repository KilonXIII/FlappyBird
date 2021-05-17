using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RePosition : MonoBehaviour
{
    public float minX = -30f;


   
    
    void Update()
    {
        if(minX > transform.position.x) 
        {

            transform.Translate(20.48f * 2, 0, 0);
        }
            
    }
}
