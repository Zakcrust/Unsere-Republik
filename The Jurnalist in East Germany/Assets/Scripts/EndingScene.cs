using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingScene : MonoBehaviour
{
    public string[] textList;
    public Text textPos;
    public List<Sprite> imageList;
    public Image imagePos;
    private int index;

    void Start()
    {
        if(GameManager.instance.getPositiveScore() > GameManager.instance.getNegativeScore())
        {
            index = 0;
        }
        else if(GameManager.instance.getNegativeScore() > GameManager.instance.getPositiveScore())
        {
            index = 1;
        }
        else
        {
            index = 1;
        }

        ChangeText(index);
    }

    public void ChangeText(int id)
    {
        textPos.text = textList[id];
        imagePos.sprite = imageList[id];
    }

}
