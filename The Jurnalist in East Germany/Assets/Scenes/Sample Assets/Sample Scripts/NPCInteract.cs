using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCInteract : MonoBehaviour, NPCManager, NPCText<string>
{
    public string[] NPCText;
    public string[] PositiveAnswers;
    public string[] NegativeAnswers;
    public Text displayText, positiveText, negativeText;
    public GameObject popUp;
    public GameObject interactionLayout;
    public GameObject buttonLayout;
    public bool positiveAnswer;
    public bool negativeAnswer;
    public bool isAnswered = false;
    public int currentTextId = 0;
    
    void Start()
    {
        popUp.SetActive(false);
        interactionLayout.SetActive(false);
        buttonLayout.SetActive(false);
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
        if(isAnswered)
            return;
        if(Input.GetKey(KeyCode.Space))
        {
            OnTrigger();
            displayTextById(currentTextId);
            ButtonOn();
        }
        /* if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(currentTextId < NPCText.Length)
            {
                currentTextId ++;
                displayTextById(currentTextId);
            }    
            if(currentTextId == NPCText.Length -1)
            {
                ButtonOn();
            }
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(currentTextId > 0)
            {
                currentTextId --;
                displayTextById(currentTextId);
            }       
        } */
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        popUp.SetActive(true);
        currentTextId = 0;
        GameManager.instance.setCurrentNPC(this);
    }

    void OnTriggerExit2D(Collider2D col)
    {
        OffTrigger();
    }

    public void OnTrigger()
    {
        interactionLayout.SetActive(true);
    }

    public void OffTrigger()
    {
        popUp.SetActive(false);
        interactionLayout.SetActive(false);
        buttonLayout.SetActive(false);
    }

    public void setText(string text)
    {
        displayText.text = text;
    }

    public void ButtonOn()
    {
        buttonLayout.SetActive(true);
    }
    public void displayTextById(int id)
    {
        setText(NPCText[id]);
        setPositiveText(PositiveAnswers[id]);
        setNegativeText(NegativeAnswers[id]);
    }

    public void Answered()
    {   if(currentTextId < NPCText.Length - 1)
        {
            currentTextId++;
            displayTextById(currentTextId);
            return;
        }
        isAnswered = true;
        interactionLayout.SetActive(false);
        buttonLayout.SetActive(false);
    }

    public void setPositiveText(string text)
    {
        positiveText.text = text;
    }

    public void setNegativeText(string text)
    {
        negativeText.text = text;
    }
}