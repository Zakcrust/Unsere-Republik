using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteract : MonoBehaviour
{
    private string NPCText = "This is an NPC text";
    public GameObject popUp;
    public GameObject interactionLayout;

    void Start()
    {
        popUp.SetActive(false);
        interactionLayout.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        popUp.SetActive(true);
        interactionLayout.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D col)
    {
        popUp.SetActive(false);
        interactionLayout.SetActive(false);
    }

}
