﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private NPCInteract currentNPC;
    private int _interactPoint = 0;
    private int PositiveScore = 0;
    private int NegativeScore = 0;
    public int InteractPoint{
        get; set;
    }
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
        InteractPoint++;
        Debug.Log(InteractPoint);
        PlayerObjective.instance.checkPoint();
    }

    public void substractScore()
    {
        NegativeScore ++;
        Debug.Log("Negative Score : "+ NegativeScore);
        currentNPC.Answered(false);
        InteractPoint++;
        Debug.Log(InteractPoint);
        PlayerObjective.instance.checkPoint();
    }

    public void setCurrentNPC(NPCInteract NPC)
    {
        currentNPC = NPC;
        Debug.Log(currentNPC);
    }
}