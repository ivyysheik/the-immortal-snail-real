using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class potion : MonoBehaviour
{
    public GameObject player;
    public GameObject speedPotion;





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
        float spawnTimer = spawnTimer =+ Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(speedPotion, randonSpawnPosition, Quaternion.identity);
            Debug.Log("I should have spawned");
            spawnTimer = 0;
        }
    }
 }
