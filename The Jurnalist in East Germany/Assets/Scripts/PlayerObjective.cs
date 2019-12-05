using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerObjective : MonoBehaviour
{
    public static PlayerObjective instance;
    public string[] objectives;
    public Text objectiveText;
    public int objectiveId = 0;
    private int currentInteractPoint = 0;
    public int[] defaultInteractPoint;
    public int interactPointRequired{
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

        //DontDestroyOnLoad(gameObject);
        objectiveId = 0;
        setText(objectives[objectiveId]);
        interactPointRequired = defaultInteractPoint[0];
    }

    public int getInteractPoint()
    {
        return interactPointRequired;
    }

    public int getObjectiveId()
    {
        return objectiveId;
    }
    public virtual void nextObjective()
    {
        
            objectiveId++;
            if(objectiveId < objectives.Length)
            {
                setText(objectives[objectiveId]);
                if(objectiveId < defaultInteractPoint.Length)
                    interactPointRequired = defaultInteractPoint[objectiveId];
            }        
            
    }

    public void setText(string text)
    {
        objectiveText.text = text;
    }
}
