﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private bool gameEnd;
    private NPCInteract currentNPC;
    public GameObject canvas;
    public GameObject buttonLayout;
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
        DontDestroyOnLoad(canvas);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            SceneManager.LoadScene("EndingScene");
        }
    }
    public void addScore()
    {
        PositiveScore ++;
        Debug.Log("Positive Score : "+ PositiveScore);
        if(currentNPC != null)
            currentNPC.Answered(true);
        else
            buttonLayout.SetActive(false);
        InteractPoint++;
        Debug.Log(InteractPoint);
        if(gameEnd)
            {
                SceneManager.LoadScene("EndingScene");
            }
        if(InteractPoint >= PlayerObjective.instance.getInteractPoint())
        {
            
            if(PlayerObjective.instance.getObjectiveId() == 0)
            {
                PlayerObjective.instance.nextObjective();
            }

        }
    }

    public void substractScore()
    {
        NegativeScore ++;
        Debug.Log("Negative Score : "+ NegativeScore);
        if(currentNPC != null)
            currentNPC.Answered(false);
        else
            buttonLayout.SetActive(false);
        InteractPoint++;
        Debug.Log(InteractPoint);
        if(gameEnd)
            {
                SceneManager.LoadScene("EndingScene");
            }
        if(InteractPoint >= PlayerObjective.instance.getInteractPoint())
        {
            
            if(PlayerObjective.instance.getObjectiveId() == 0)
            {
                PlayerObjective.instance.nextObjective();
            }

        }
    }

    public void setCurrentNPC(NPCInteract NPC)
    {
        currentNPC = NPC;
        Debug.Log(currentNPC);
    }

    public void checkButtonLayout()
    {
        if(buttonLayout == null)
        {
            GameObject.FindWithTag("ButtonLayout");
        }
    }

    public void setGameEnd(bool condition)
    {
        gameEnd = condition;
    }

    public bool getGameEnd()
    {
        return gameEnd;
    }

    public int getPositiveScore()
    {
        return PositiveScore;
    }

    public int getNegativeScore()
    {
        return NegativeScore;
    }
}
