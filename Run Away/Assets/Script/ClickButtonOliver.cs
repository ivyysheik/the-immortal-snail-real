using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButtonOliver : MonoBehaviour
{
    public GameObject EnterText;
    public GameObject AboutText;
    public GameObject BackButton;

    // Start is called before the first frame update
    void Start()
    {
        EnterText.SetActive(false);
        AboutText.SetActive(true);
        BackButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        EnterText.SetActive(false);
        AboutText.SetActive(true);
        BackButton.SetActive(true);
    }
}
