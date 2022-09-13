using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeMenu : MonoBehaviour
{
    public GameObject menuGUI;

    public bool isEscMenuOpen;

    // Start is called before the first frame update
    public void quitGame()
    {
        Debug.Log("Exiting the Game");
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isEscMenuOpen)
        {
            menuGUI.gameObject.SetActive(true);
            isEscMenuOpen = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            closeMenu();
        }
    }

    public void closeMenu()
    {
        menuGUI.gameObject.SetActive(false);
        isEscMenuOpen = false;
    }
}
