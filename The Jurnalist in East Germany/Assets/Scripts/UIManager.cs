using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
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

    public GameObject interactionLayout;
    public GameObject buttonLayout;
    public Text displayText;
    public Text positiveText;
    public Text negativeText;
    public GameObject blackPanel;

    public GameObject getInteractionLayout()
    {
        return interactionLayout;
    }

    public GameObject getButtonLayout()
    {
        return buttonLayout;
    }

    public GameObject getBlackPanel()
    {
        return blackPanel;
    }

    public Text getDisplayText()
    {
        return displayText;
    }

    public Text getPositiveText()
    {
        return positiveText;
    }

    public Text getNegativeText()
    {
        return negativeText;
    }

}
