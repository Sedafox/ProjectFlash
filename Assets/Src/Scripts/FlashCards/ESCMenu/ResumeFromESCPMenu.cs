using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeFromESCPMenu : MonoBehaviour
{
    public GameObject menuGUI;

    public EscapeMenu escapeMenu;

    // Start is called before the first frame update
    public void resumeFromMenu()
    {
        menuGUI.gameObject.SetActive(false);
        escapeMenu.isEscMenuOpen = false;
    }
}
