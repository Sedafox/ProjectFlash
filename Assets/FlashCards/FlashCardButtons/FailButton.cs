using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailButton : MonoBehaviour
{
    public CardManager cardManager;

    public Button failButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = failButton.GetComponent<Button>();
        btn.onClick.AddListener (TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void TaskOnClick()
    {
        Debug.Log("You clicked the Fail Button");
        cardManager.numOfFail++;
        Debug
            .Log("Pass: " +
            cardManager.numOfPass +
            ", Fail: " +
            cardManager.numOfFail);
        cardManager.closeFlashCard();
    }
}
