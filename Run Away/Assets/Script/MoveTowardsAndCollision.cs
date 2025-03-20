using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;
using TMPro;
using System;
using JetBrains.Annotations;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject Player;
    public GameObject Enemy;
    public float speed;      
    public EnterToPlay enterToPlay;
    public GameObject Death;
    public AudioSource Splat;

    private bool timerActive; 
    private float currentTime;
    public bool playerIsDead;
    private float speedNow;
    

    [SerializeField] private TMP_Text _text;


    






    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;

        Death.SetActive(false);

        Splat = GetComponent<AudioSource>();
        

      
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        StopTimer();
        Death.SetActive(true);
        playerIsDead = true;
        Splat.Play();
       
    }



    // Update is called once per frame
    private void Update()
    {
        if  (timerActive == true)
        {

            float singleStep = speedNow * Time.deltaTime * 100000;

            Vector3 DirectionToPlayer = (Player.transform.position - Enemy.transform.position); 

            
            Quaternion targetRotation = Quaternion.LookRotation(DirectionToPlayer.normalized);
            Enemy.transform.rotation = Quaternion.RotateTowards(Enemy.transform.rotation, targetRotation, singleStep);
            Enemy.transform.position = Vector3.MoveTowards(Enemy.transform.position, Player.transform.position, speedNow);
            

            
            
        




            //Vector3 DirectionToPlayer = Enemy.transform.position - Player.transform.position; 
            //singleStep = speedNow * Time.deltaTime;

              //Enemy.transform.forward, DirectionToPlayer, singleStep, 0.0f, 
        }

        if (timerActive)
        {
            currentTime = currentTime + Time.deltaTime;
            _text.text = currentTime.ToString();

            enterToPlay.Playing = true;
        }

         if (Input.GetKeyDown(KeyCode.Escape))
         {
            StartTimer();
         }

         if (playerIsDead == true)
         {
            Splat.Play();

         }

            if (Input.GetKeyDown(KeyCode.Space))

            {
            print("input fired");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

        speedNow = speed * currentTime;
    }

    public void StartTimer()
    {
        timerActive = true; 
    }

    public void StopTimer()
    {
        timerActive = false; 
    }
       
    }






