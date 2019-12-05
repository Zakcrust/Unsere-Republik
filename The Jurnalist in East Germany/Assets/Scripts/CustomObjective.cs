using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomObjective : PlayerObjective
{
    public override void nextObjective()
    {
        objectiveId++;
        if(objectiveId < objectives.Length)
        {
            setText(objectives[objectiveId]);
            if(objectiveId < defaultInteractPoint.Length)
                interactPointRequired = defaultInteractPoint[objectiveId];
        }
         SceneManager.LoadScene("EndingScene");
    }
}
