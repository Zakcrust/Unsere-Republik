using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuTransition : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Intro");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
