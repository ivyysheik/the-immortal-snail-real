using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionflash : MonoBehaviour
{

    public GameObject potion;
    public float flashTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("flash", 1f, flashTime);
    }
void flash()
{
    potion.SetActive(!potion.activeInHierarchy);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
