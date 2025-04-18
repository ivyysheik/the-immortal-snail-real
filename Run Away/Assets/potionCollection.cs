using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionCollection : MonoBehaviour
{
    public GameObject player;
    public GameObject speedPotion;
    public float spawnTimer;
    public AudioSource audioPlayer;
    public float despawnTimer;

    public float flashTime = 1f;

    public bool isFlashing = false;

    private void Update()
    {
        despawnTimer += Time.deltaTime;

        if (despawnTimer >= 2.5f && !isFlashing)
        {
            InvokeRepeating("flash", 0.3f, flashTime);
            isFlashing = true;
        }

        if (despawnTimer >= 3f)
        {
            CancelInvoke("flash");
            Destroy(gameObject);
            despawnTimer = 0f;
        }
    }

    void flash()
    {
        if (speedPotion != null)
        {
            speedPotion.SetActive(!speedPotion.activeInHierarchy);
            Debug.Log("Flashing: " + speedPotion.name + " is now " + (speedPotion.activeInHierarchy ? "active" : "inactive"));
        }
        else
        {
            Debug.LogError("speedPotion is not assigned!");
        }
    }

    void Start()
    {
        despawnTimer += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        player.GetComponent<PlayerMovement>().walkSpeed += 1.5f;
        Destroy(gameObject);
        audioPlayer.Play();
    }
}