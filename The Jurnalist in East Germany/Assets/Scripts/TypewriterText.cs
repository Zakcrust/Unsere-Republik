using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TypewriterText : MonoBehaviour
{
    public string fullText;
    public string currText = "";
    public float delay;
    public AudioSource typingSound;

    void Start()
    {
        StartCoroutine(Typing());
    }

    IEnumerator Typing()
    {
        for(int i = 0; i <= fullText.Length; i++)
        {
            yield return new WaitForSeconds(delay);
            currText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currText;
            this.GetComponent<AudioSource>().Play();
        }
    }
}
