using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
   
    int TakeDamageFromFireBall()
    {
        int playerHealth = 100;
        return playerHealth - 5;
    }

    int TakeDamageFromFireBall (int damage)
    {
        int playerHealth = 100;
        return playerHealth - damage;
    }

    int TakeDamageFromFireBall(int damage, int playerHealth)
    {
        return playerHealth - damage;
    }


    void Start()
    {
        int x = TakeDamageFromFireBall();
        Debug.Log("Player health: " + x);

        int y = TakeDamageFromFireBall(25);
        Debug.Log("Player health: " + y);

        int z = TakeDamageFromFireBall(30, 50);
        Debug.Log("Player health: " + z);
    }

   
    void Update()
    {
        
    }
}
