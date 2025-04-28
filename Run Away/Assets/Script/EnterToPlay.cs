using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterToPlay : MonoBehaviour
{
    public GameObject Enterisplay;
    public bool Playing = false;
    public GameObject titleCard;
    public GameObject titleImage;
    public GameObject BackButton;
    public GameObject escapeButton;

    public GameObject quitButton;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1; 
            Enterisplay.SetActive(false);
            titleCard.SetActive(false);
            titleImage.SetActive(false);
            BackButton.SetActive(false);
            escapeButton.SetActive(false);
            quitButton.SetActive(false);

            Playing = true;


        }
    }
}
