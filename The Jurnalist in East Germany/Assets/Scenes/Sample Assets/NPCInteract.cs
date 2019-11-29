using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCInteract : MonoBehaviour, NPCManager, NPCText<string>
{
    public string NPCText = "Commit Sudoku";
    public Text displayText;
    public GameObject popUp;
    public GameObject interactionLayout;

    void Start()
    {
        popUp.SetActive(false);
        interactionLayout.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        LayoutOn();
        setText(NPCText);
    }

    void OnTriggerExit2D(Collider2D col)
    {
        popUp.SetActive(false);
        interactionLayout.SetActive(false);
    }

    public void LayoutOn()
    {
        popUp.SetActive(true);
        interactionLayout.SetActive(true);
    }

    public void LayoutOff()
    {
        popUp.SetActive(false);
        interactionLayout.SetActive(false);
    }

    public void setText(string text)
    {
        displayText.text = NPCText;
    }
}
