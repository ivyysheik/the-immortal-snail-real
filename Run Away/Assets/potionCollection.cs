using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionCollection : MonoBehaviour
{
    public GameObject player;
    public GameObject speedPotion;
    public float spawnTimer;
    public AudioSource audioPlayer;





    void Start()
    {

    }


    private void OnTriggerEnter(Collider other)
    {

        player.GetComponent<PlayerMovement>().walkSpeed += 1.5f;
        Destroy(gameObject);
        audioPlayer.Play(); 
    }
}
