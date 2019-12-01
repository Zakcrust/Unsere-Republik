using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NewspaperChoice : MonoBehaviour
{
    public List<string> pool;
    public List<string> pickedText;
    public List<string> calledText;
    public List<GameObject> position;

    private string choiceTemp;

    void Start()
    {
        RandomText();
    }
    public void PickingChoice()
    {
        string buttonValue = EventSystem.current.currentSelectedGameObject.GetComponent<Text>().text;
        pickedText.Add(buttonValue);
    }
    public void RandomText()
    {
        foreach (GameObject pos in position)
        {
            string randValue = pool[Random.Range(0, pool.Count)];
            pos.GetComponent<Text>().text = randValue;
            pool.Remove(randValue);
            calledText.Add(randValue);
        }
        pool.AddRange(calledText);
        calledText.Clear();
    }
    public void CheckVal()
    {

    }
}
