using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject obstacle;
    

    private void Start()
    {
        Destroy(obstacle, 7.0f); 
    }
    
   
    
    private void Update()
    {
        if(transform.position.x < 0){    
            transform.Translate(0.5f*Time.deltaTime,0,0);

        }else{
            transform.Translate(-0.5f*Time.deltaTime,0,0);
        }
        
    }
}
