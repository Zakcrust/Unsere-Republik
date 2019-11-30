using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private NPCInteract currentNPC;
    private int score = 0;
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void addScore()
    {
        score ++;
        Debug.Log(score);
        currentNPC.Answered();
    }

    public void substractScore()
    {
        score --;
        Debug.Log(score);
        currentNPC.Answered();
    }

    public void setCurrentNPC(NPCInteract NPC)
    {
        currentNPC = NPC;
        Debug.Log(currentNPC);
    }
}
