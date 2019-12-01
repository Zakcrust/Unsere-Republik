using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingScene : MonoBehaviour
{
    public List<Text> textList;
    public Text textPos;
    public List<Image> imageList;
    public Image imagePos;
    private int index;

    public void ChangeText()
    {
        textPos.text = textList[0].text;
        imagePos.sprite = imageList[0].sprite;
    }
}
