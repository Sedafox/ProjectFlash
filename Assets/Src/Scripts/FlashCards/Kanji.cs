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

    public IEnumerable<String> allKanji;

    public string findKanjiDef(string currentKanji, string desiredOutput)
    {
        var kanjis =
            new []
            {
                new Kanji {
                    textKanji = "本",
                    Hiragana = "ほん",
                    englishTranslation = "book; volume; script"
                },
                new Kanji {
                    textKanji = "水",
                    Hiragana = "みず",
                    englishTranslation =
                        "water (esp. cool, fresh water, e.g. drinking water"
                },
                new Kanji {
                    textKanji = "ステキ",
                    Hiragana = "",
                    englishTranslation =
                        "lovely; wonderful; nice; great; fantastic; superb; cool"
                },
                new Kanji {
                    textKanji = "車",
                    Hiragana = "くるま",
                    englishTranslation = "car"
                }
            };

        allKanji = from k in kanjis select k.textKanji;

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
        var lastUsedKanji = currentCardKanji;
        var random = new System.Random();

        int index = random.Next(myLearnedKanjis.Count);
        currentCardKanji = myLearnedKanjis[index];
        while (lastUsedKanji == currentCardKanji //if last used kanji is the same as the one just generated, too bad, pick a different one
        )
        {
            random = new System.Random();
            index = random.Next(myLearnedKanjis.Count);
            currentCardKanji = myLearnedKanjis[index];
        }
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

    public void generateDictionary()
    {
        //initalize dictionary (We have to initialize this)
        findKanjiDef("本", "hiragana");

        //end initalization
        foreach (String item in allKanji)
        {
            addTolearnedKanjis (item);
            Debug.Log (item);
        }
    }
}
