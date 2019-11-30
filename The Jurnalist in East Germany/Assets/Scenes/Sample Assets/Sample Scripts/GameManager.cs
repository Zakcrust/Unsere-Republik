using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private NPCInteract currentNPC;
    private int PositiveScore = 0;
    private int NegativeScore = 0;
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
        PositiveScore ++;
        Debug.Log("Positive Score : "+ PositiveScore);
        currentNPC.Answered(true);
    }

    public void substractScore()
    {
        NegativeScore ++;
        Debug.Log("Negative Score : "+ NegativeScore);
        currentNPC.Answered(false);
    }

    public void setCurrentNPC(NPCInteract NPC)
    {
        currentNPC = NPC;
        Debug.Log(currentNPC);
    }
}
