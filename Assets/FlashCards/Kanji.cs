using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Kanji : MonoBehaviour
{
    public string textKanji { get; set; }

    public string Hiragana { get; set; }

    public string Katakana { get; set; }

    public string englishTranslation { get; set; }

    public List<string> myLearnedKanjis = new List<string>();

    public string findKanjiDefintion(string currentKanji)
    {
        var kanjis =
            new []
            {
                new Kanji {
                    textKanji = "本",
                    Hiragana = "ひらがな",
                    englishTranslation = "Book"
                },
                new Kanji {
                    textKanji = "水",
                    Hiragana = "みず",
                    englishTranslation = "Water"
                }
            };

        string KanjiMeaning =
            (
            from k in kanjis
            where k.textKanji == currentKanji select k.englishTranslation
            ).First();

        return KanjiMeaning;
    }

    public void addTolearnedKanjis(string newKanji)
    {
        myLearnedKanjis.Add (newKanji);
    }

    public string returnRandomLearnedKanji()
    {
        var random = new System.Random();

        int index = random.Next(myLearnedKanjis.Count);
        return myLearnedKanjis[index];
    }

    void Start()
    {
    }
}
