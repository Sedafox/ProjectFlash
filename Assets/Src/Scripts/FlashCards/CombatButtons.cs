using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatButtons : MonoBehaviour
{
    public GameObject actionBar;

    public CardManager CardManager;

    public void onAttackButtonClick()
    {
        CardManager.hideCActionBar();
        CardManager.loadFlashCard();
    }
}
