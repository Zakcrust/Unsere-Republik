using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroTransition : MonoBehaviour
{
    public float delay;
    public Animator transitionAnim;
    public GameObject opening;

    void Start()
    {
        StartCoroutine(Fading());
    }
    IEnumerator Fading()
    {
        opening.transform.GetChild(0).gameObject.SetActive(true);
        yield return new WaitForSeconds(delay);
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(0.8f);
        opening.transform.GetChild(0).gameObject.SetActive(false);
        transitionAnim.SetTrigger("new");
        yield return new WaitForSeconds(0.8f);
        GameObject.Find("Canvas").transform.GetChild(1).gameObject.SetActive(true);
        opening.transform.GetChild(1).gameObject.SetActive(true);
        yield return new WaitForSeconds(8f);
        transitionAnim.SetTrigger("end");
        SceneManager.LoadScene("SCENE_1");
    }
}
