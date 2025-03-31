using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseInput : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        if (mxVal != 0)
            Debug.Log("Mouse X movement selected: " + mxVal);
        if (myVal != 0)
            Debug.Log("Mouse Y movement selected: " + myVal);


      
    }
}
