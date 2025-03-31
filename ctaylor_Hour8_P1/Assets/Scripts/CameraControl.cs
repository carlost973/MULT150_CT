using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    

    void Start()
    {
      
    }

    
    void Update()
    {

        transform.position += new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0) * 0.1f;
    }
}
