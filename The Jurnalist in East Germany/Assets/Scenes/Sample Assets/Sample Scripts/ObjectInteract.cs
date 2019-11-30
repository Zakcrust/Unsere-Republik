using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectInteract : MonoBehaviour, NPCInterface, NPCText<string>
{
    public GameObject interactionLayout, popUp;
    public Text text;
    public string objectText;
    public bool isIterating = false;
    public void OnTrigger()
    {
        interactionLayout.SetActive(true);
        setText(objectText);
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        popUp.SetActive(true);
    }

    public void OnTriggerStay2D(Collider2D col)
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            if(!isIterating)
            {
                interactionLayout.SetActive(true);
                StartCoroutine(iterateText(objectText));
            }
                
        }
        else if(Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Game Ended - Changing Scene ...");
        }
    }
    public void OnTriggerExit2D(Collider2D col)
    {
        popUp.SetActive(false);
        interactionLayout.SetActive(false);
    }
    public void setText(string text)
    {
        this.text.text = text;
    }

    public IEnumerator iterateText(string text)
    {
        isIterating = true;
        string temp = "";
        foreach(char a in text)
        {
            temp+= a;
            setText(temp);
            yield return new WaitForSeconds(0.01f);
        }
        isIterating = false;
    }
}
