using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class potion : MonoBehaviour
{
    Player = GameObject.FindWithTag("Player");
    private void Start()
    {
        
    }
      
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
         
        Player.speed  =+ 10; 
    }
}