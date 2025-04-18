using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{

    public float moveSpeed = 5f;

    void Start()
    {
        
    }

   
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); 
        float moveY = Input.GetAxis("Vertical");   

        
        transform.Translate(moveX * moveSpeed * Time.deltaTime, moveY * moveSpeed * Time.deltaTime, 0);
    }
}
