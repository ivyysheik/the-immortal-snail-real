using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class potion : MonoBehaviour
{
    public GameObject player;
    public GameObject speedPotion;
    public float spawnTimer; 
    
    private potionCollection potionScript;
    
 





     void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
       
        player.GetComponent<PlayerMovement>().walkSpeed = +1000000;
        Destroy(gameObject);
    

    }

    private void Update()
    {
        

        Vector3 randonSpawnPosition = new Vector3(Random.Range(1820, 1828), -368, Random.Range(-1049, -1040));

        spawnTimer += Time.deltaTime;
   
        Debug.Log(spawnTimer);


      

        if (spawnTimer > 5)
        {
            spawnTimer = 0;

            float minimumDistance = 0.1f; 
            if (Vector3.Distance(player.transform.position, randonSpawnPosition) < minimumDistance)
            {
              spawnTimer = 4.9f; 
              return; 
              
            }
            potionScript = speedPotion.GetComponent<potionCollection>();
            potionScript.enabled = true;
            Instantiate(speedPotion, randonSpawnPosition, Quaternion.identity);
           
          
          
       
            Debug.Log(spawnTimer);
        }
    }
 }
