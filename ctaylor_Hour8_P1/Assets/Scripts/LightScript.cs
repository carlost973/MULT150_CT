using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.L))
        {
            Light pointLight = GetComponent<Light>();
            if (pointLight != null)
            {
                pointLight.enabled = !pointLight.enabled;
            }
        }
    }
}