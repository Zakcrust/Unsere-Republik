using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CinematicInteract : MonoBehaviour, NPCInteractInterface, NPCText<string>
{
   public Camera camera;
   public int currentTextId;
   private bool isIterating = false;
   private bool isInteracting = false;
   public string[] NPCText;
   public MainCharacter mainCharacter;
   public string positiveAnswer, negativeAnswer;
   public GameObject interactionLayout;
   public GameObject buttonLayout, popUp;
   public Text displayedText,positiveText,negativeText;

   void Update()
   {
       if(!isInteracting)
            return;
       if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            if(currentTextId == NPCText.Length - 1)
            {
                interactionLayout.SetActive(false);
            }
            if(currentTextId < NPCText.Length)
            {
                if(!isIterating)
                {
                    currentTextId ++;
                    StartCoroutine(iterateText(NPCText[currentTextId]));
                }
                
                //displayTextById(currentTextId);

                if(currentTextId == NPCText.Length)
                {
                Invoke("finishConversation",2);
                }  
            }
         }
   }

    public void OnTriggerStay2D(Collider2D col)
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            if(!isIterating)
            {
                interactionLayout.SetActive(true);
                //StartCoroutine(iterateText(objectText));
            }
                
        }
        else if(Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Game Ended - Changing Scene ...");
            OnTrigger();
        }
    }
   
    void OnTriggerEnter2D(Collider2D col)
    {
        popUp.SetActive(true);
        currentTextId = 0;
    }

   public void OnTrigger()
    {
        mainCharacter.enabled = false;
        camera.transform.position = new Vector3(25,camera.transform.position.y,camera.transform.position.z);
        isInteracting = true;
    }
   public void OffTrigger()
   {
       return;
   }
   public void ButtonOn()
   {
       buttonLayout.SetActive(true);
   }
    public void setText(string text)
    {
        displayedText.text = text;
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
    // Start is called before the first frame update
}
