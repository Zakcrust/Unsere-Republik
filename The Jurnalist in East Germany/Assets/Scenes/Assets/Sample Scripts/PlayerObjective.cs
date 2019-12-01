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
    public int interactPointRequired;
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

        setText(objectives[objectiveId]);
    }
    public void nextObjective()
    {
        objectiveId++;
        setText(objectives[objectiveId]);
    }

    public void setText(string text)
    {
        objectiveText.text = text;
    }

    public void checkPoint()
    {
        Debug.Log("Current Interact Point : "+GameManager.instance.InteractPoint);
        Debug.Log("Required Interact Point : "+interactPointRequired);
        if(GameManager.instance.InteractPoint >= interactPointRequired)
        {
            nextObjective();
        }
    }
}
