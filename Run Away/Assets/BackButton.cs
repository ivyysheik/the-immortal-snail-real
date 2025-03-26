using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public Button backButton;
    public GameObject ButtonObject;
    public GameObject EnterText;
    public GameObject AboutText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        backButton.onClick.AddListener(backInMenu);
    }

    private void backInMenu()
    {
        EnterText.SetActive(true);
        AboutText.SetActive(false);
        ButtonObject.SetActive(false);
    }
}
