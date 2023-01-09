using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addObstacle : MonoBehaviour
{
    public GameObject obstacle;

    

    private void Start()
    {
        InvokeRepeating("add_obstacle",0.0f, 3.0f);  
        
    }

    void add_obstacle(){
        float random = Random.Range(-7.5f, 7.5f);
        GameObject new_obstacle = Instantiate(obstacle, new Vector3(random, 1,-5), Quaternion.identity);
    }

   

   
   
}
