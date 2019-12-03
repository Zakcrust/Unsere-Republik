using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndPointInteract_1 : MonoBehaviour, NPCInterface, NPCText<string>
{
    public GameObject popUp;
    Text displayedText;
    public string objectText;
    public bool isIterating = false;
    GameObject interactionLayout;

    void Start()
    {
        interactionLayout = UIManager.instance.getInteractionLayout();
        displayedText = UIManager.instance.getDisplayText();
    }

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
            if(GameManager.instance.InteractPoint < PlayerObjective.instance.interactPointRequired)
            {
                if(!isIterating)
                {
                    interactionLayout.SetActive(true);
                    StartCoroutine(iterateText("Selesaikan misi anda"));
                }
            }
            
            if(!isIterating)
            {
                interactionLayout.SetActive(true);
                StartCoroutine(iterateText("Tekan C untuk masuk ke dalam apartement"));
                //StartCoroutine(iterateText(objectText));
            }
                
        }
        else if(Input.GetKeyDown(KeyCode.C))
        {
            if(GameManager.instance.InteractPoint < 2)
                return;
            Debug.Log("Game Ended - Changing Scene ...");
            GameManager.instance.InteractPoint = 0;
            SceneManager.LoadScene("SCENE_2");
        }
    }
    public void OnTriggerExit2D(Collider2D col)
    {
        popUp.SetActive(false);
        interactionLayout.SetActive(false);
    }
    public void setText(string displayedText)
    {
        this.displayedText.text = displayedText;
    }

    public IEnumerator iterateText(string displayedText)
    {
        isIterating = true;
        string temp = "";
        foreach(char a in displayedText)
        {
            temp+= a;
            setText(temp);
            yield return new WaitForSeconds(0.01f);
        }
        isIterating = false;
    }
}
