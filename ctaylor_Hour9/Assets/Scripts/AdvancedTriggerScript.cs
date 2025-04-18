using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedTriggerScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        string triggerName = gameObject.name;

        if (triggerName == "LTrigger")
        {
            print(other.gameObject.name + " has entered LTrigger");
        }
        else if (triggerName == "RTrigger")
        {
            print(other.gameObject.name + " has entered RTrigger");
        }
        else
        {
            print(other.gameObject.name + " has entered " + triggerName);
        }
    }

    void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " is still in " + gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " has left " + gameObject.name);
    }



    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
