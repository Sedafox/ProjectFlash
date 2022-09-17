using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassButton : MonoBehaviour
{
    public CardManager cardManager;

    public EnemyManager enemyManager;

    public Button continueButton;

    public Button incorrectButton;

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
        cardManager.numOfTimesCardHasBeenShown++;

        if (cardManager.numOfTimesCardHasBeenShown == 3)
        {
            cardManager.closeFlashCard();
            cardManager.hideAnswers();
            cardManager.numOfTimesCardHasBeenShown = 0;

            //Enemy Health -1
            enemyManager.currentHealth -= 1;
        }
        else
        {
            cardManager.hideAnswers();
            incorrectButton.gameObject.SetActive(false);
            correctButton.gameObject.SetActive(false);
            continueButton.gameObject.SetActive(true);
            cardManager.displayNewKanji();
        }
    }
}
