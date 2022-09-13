using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ContinueButton : MonoBehaviour
{
    public Button continueButton;
    public Button incorrectButton;
    public Button correctButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = continueButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick(){
		Debug.Log ("You have clicked the button!");
        continueButton.gameObject.SetActive(false);
        incorrectButton.gameObject.SetActive(true);
        correctButton.gameObject.SetActive(true);
	}
}
