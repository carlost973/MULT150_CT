using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{

    private int collisionCount = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cube") 
        {
            collisionCount++;
            Debug.Log("Bounce count: " + collisionCount);
        }
    }


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
