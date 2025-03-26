using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aboutButton : MonoBehaviour
{
    public GameObject EnterText;
    public GameObject AboutText;
    public GameObject BackButton;
    // Start is called before the first frame update

    public Button button;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        EnterText.SetActive(false);
        AboutText.SetActive(true);
        BackButton.SetActive(true);
    }
}
