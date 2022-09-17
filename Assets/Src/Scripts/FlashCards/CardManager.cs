using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/*
Example of a Kanji

This is a Kanji　髪
This is the spelling of the Kanji (referred to as hiragana) かみ
This is the english translation: hair
*/
public class CardManager : MonoBehaviour
{
    public int numOfPass; //Just some data I think is good to initalized. Not used in anything yet.

    public int numOfFail; //Just some data I think is good to initalized. Not used in anything yet.

    public Kanji Kanji; //This is the Kanji script, which is responsible for handling all things Kanji.

    public TextMeshProUGUI flashCardText; //This references the text on the flashcard

    public GameObject FlashCardCanvas; //This references the flash card in totality

    public GameObject AnswerPanel; //This references the back of the flash card (The answer)

    public TextMeshProUGUI hiraganaAnswerText; //This references the text responsible for showing the Kanji's hiragana

    public TextMeshProUGUI englishTranslationAnswerText; //This referrences the text responsible for showing the english translation of the Kanji

    public GameObject actionBar;

    // Start is called before the first frame update
    void Start()
    {
        //Some Kanji need to be populated for the flash card to work
        Kanji.generateDictionary();

        //In the future the player will obtain these Kanji naturally by playing the game
        //End of Test Data population
        flashCardText.text = Kanji.returnRandomLearnedKanji(); //We set the text of the flash card to a randomly learned Kanji (which was declared above)
    }

    public void loadFlashCard() //This function is used for loading the flash card canvas
    {
        FlashCardCanvas.SetActive(true); //load the flash card canvas (make it visible, make it clickable, and make it fabulous)
    }

    public void closeFlashCard() //This function is used for closing the parent flash card canvas
    {
        FlashCardCanvas.SetActive(false); //unload the flash card canvas (make it invisible and make it not clickable)
    }

    public void showAnswers() //This function is used for displaying the back of the flash card
    {
        hiraganaAnswerText.text = Kanji.hiraganaAnswer();

        //Kanji.hiraganaAnswer() will return the hiragana of the current Kanji. We take that and set the text of the hiragana on the answer card to it.
        englishTranslationAnswerText.text = Kanji.englishTranslationAnswer();

        //Kanji.englishTranslationAnswer() will return the english translation of the current Kanji. We take that and set the text of the english translation
        //On the answer card to it
        AnswerPanel.gameObject.SetActive(true);
        //And finally we make sure that the answer card can actually be seen and interacted with
    }

    public void hideAnswers() //This function is used for hiding the back of the flash card
    {
        AnswerPanel.gameObject.SetActive(false);
        //Set the Answer Panel to not active
    }

    public void showActionBar()
    {
        actionBar.gameObject.SetActive(true);
    }

    public void hideCActionBar()
    {
        actionBar.gameObject.SetActive(false);
    }

    public void saveFlashCard() //This function is used to save the cards already learned. In the future, this function may be moved to a Save Data Class.
    {
        if (Kanji.myLearnedKanjis != null)
        //We don't want to save anything to the file if the playit to the text on the answer carder hasn't learned any Kanji's yet
        {
            File
                .WriteAllLines("MyLearnedKanjis_test2.save",
                Kanji.myLearnedKanjis); //function for saving the learned Kanji to the file
        }
    }

    public void loadAllLearnedKanjiFromFile() //This function is used to load the cards already saved. In the future, this function may be moved to a Load Data Class.
    {
        Kanji.myLearnedKanjis =
            File.ReadAllLines("MyLearnedKanjis_test2.save").ToList();
        //function for loading the learned Kanji from the file
    }
}
