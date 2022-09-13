using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour
{
    public Button continueButton;

    public Button incorrectButton;

    public Button correctButton;

    public GameObject answerPanel;

    public CardManager cardManager;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = continueButton.GetComponent<Button>();
        btn.onClick.AddListener (TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        continueButton.gameObject.SetActive(false);
        incorrectButton.gameObject.SetActive(true);
        correctButton.gameObject.SetActive(true);
        cardManager.showAnswers();
    }
}
