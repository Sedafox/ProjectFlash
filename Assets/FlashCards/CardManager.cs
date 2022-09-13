using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    public int numOfPass;

    public int numOfFail;

    public Kanji Kanji;

    public TextMeshProUGUI flashCardText;

    public GameObject FlashCardCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Kanji.addTolearnedKanjis("本");
        flashCardText.text = Kanji.returnRandomLearnedKanji();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void loadFlashCard()
    {
        FlashCardCanvas.SetActive(true);
    }

    public void closeFlashCard()
    {
        FlashCardCanvas.SetActive(false);
    }

    public void saveFlashCard()
    {
        if (Kanji.myLearnedKanjis != null)
        {
            File.WriteAllLines("MyLearnedKanjis_test2", Kanji.myLearnedKanjis);
        }
    }

    public void loadAllLearnedKanjiFromFile()
    {
        Kanji.myLearnedKanjis =
            File.ReadAllLines("MyLearnedKanjis_test2").ToList();
    }
}
