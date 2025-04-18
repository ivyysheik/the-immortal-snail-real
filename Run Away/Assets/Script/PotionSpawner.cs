using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionSpawner : MonoBehaviour
{
    public GameObject speedPotion;
    public float spawnTimer; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
      private void Update()
    {
        

        Vector3 randonSpawnPosition = new Vector3(Random.Range(1820, 1828), -368, Random.Range(-1049, -1040));

        spawnTimer =+ Time.deltaTime;

        Debug.Log(spawnTimer);
        if (spawnTimer > 5)
        {
            spawnTimer = 0;
            Instantiate(speedPotion, randonSpawnPosition, Quaternion.identity);
            Debug.Log("I should have spawned");
          
       
            Debug.Log(spawnTimer);
        }
    }
 }

