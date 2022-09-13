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

    private string currentCardKanji { get; set; }

    public List<string> myLearnedKanjis = new List<string>();

    public string findKanjiDef(string currentKanji, string desiredOutput)
    {
        var kanjis =
            new []
            {
                new Kanji {
                    textKanji = "本",
                    Hiragana = "ほん",
                    englishTranslation = "book; volume; script​"
                },
                new Kanji {
                    textKanji = "水",
                    Hiragana = "みず",
                    englishTranslation =
                        "water (esp. cool, fresh water, e.g. drinking water)​"
                },
                new Kanji {
                    textKanji = "ステキ",
                    Hiragana = "",
                    englishTranslation =
                        "lovely; wonderful; nice; great; fantastic; superb; cool​"
                }
            };

        string kanjiMeaning =
            (
            from k in kanjis
            where k.textKanji == currentKanji select k.englishTranslation
            ).First();

        string kanjiHiragana =
            (
            from k in kanjis where k.textKanji == currentKanji select k.Hiragana
            ).First();

        if (desiredOutput == "hiragana")
        {
            return kanjiHiragana;
        }
        else if (desiredOutput == "english")
        {
            return kanjiMeaning;
        }
        else
        {
            return "Sorry, please enter either hiragana or english into the findKanjiDefinition function";
        }
    }

    public void addTolearnedKanjis(string newKanji)
    {
        myLearnedKanjis.Add (newKanji);
    }

    public string returnRandomLearnedKanji()
    {
        var random = new System.Random();

        int index = random.Next(myLearnedKanjis.Count);
        currentCardKanji = myLearnedKanjis[index];
        return myLearnedKanjis[index];
    }

    public string hiraganaAnswer()
    {
        return findKanjiDef(currentCardKanji, "hiragana");
    }

    public string englishTranslationAnswer()
    {
        return findKanjiDef(currentCardKanji, "english");
    }

    void Start()
    {
    }
}
