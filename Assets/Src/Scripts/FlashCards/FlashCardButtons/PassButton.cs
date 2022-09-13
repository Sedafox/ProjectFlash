using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassButton : MonoBehaviour
{
    public CardManager cardManager;

    public EnemyManager enemyManager;

    public Button correctButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = correctButton.GetComponent<Button>();
        btn.onClick.AddListener (TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void TaskOnClick()
    {
        Debug.Log("You clicked the Pass Button");
        cardManager.numOfPass++;
        Debug
            .Log("Pass: " +
            cardManager.numOfPass +
            ", Fail: " +
            cardManager.numOfFail);
        cardManager.closeFlashCard();
        cardManager.hideAnswers();

        //Enemy Health -1
        enemyManager.currentHealth -= 1;
    }
}
