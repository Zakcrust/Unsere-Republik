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
    public bool positiveAnswer;
    public bool negativeAnswer;
    void Start()
    {
        popUp.SetActive(false);
        interactionLayout.SetActive(false);
        if(positiveAnswer && negativeAnswer)
        {
            positiveAnswer = true;
            negativeAnswer = false;
        }
        else if(!(positiveAnswer && negativeAnswer))
        {
            positiveAnswer = true;
            negativeAnswer = false;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if(Input.GetKey(KeyCode.Space))
        {
            LayoutOn();
            setText(NPCText);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        popUp.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D col)
    {
        LayoutOff();
    }

    public void LayoutOn()
    {
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