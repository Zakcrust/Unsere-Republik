using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashTransition : MonoBehaviour
{
    public float delay;
    public Animator transitionAnim;

    void Start()
    {
        StartCoroutine(Fading());
    }

    IEnumerator Fading()
    {
        yield return new WaitForSeconds(delay);
        transitionAnim.SetTrigger("out");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("MainMenu");
    }
}
