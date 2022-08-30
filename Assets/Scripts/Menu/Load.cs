using UnityEngine;
using UnityEngine.SceneManagement;


public class Load : MonoBehaviour
{
    #region Variables;
    [Tooltip("Used in interractive UI")] public GameObject examineMenu;
    [Tooltip("Used in interractive UI")] public GameObject talkMenu;
    int index;
    [Tooltip("Name the scene name exactly how its written in scene folder!")] public string scenePath;
    #endregion

    #region Scene Loading
    // Main menu Control script
    public void LoadMenu()
    {
        SceneManager.LoadScene(scenePath);
    }

    public void LoadQuiz()
    {
        SceneManager.LoadScene("Quiz");
        Time.timeScale = 1f;
    }

    /*
    public void ExitApplication() // Quit Button
    {
        Application.Quit();
    }
    */

    public void Examine()
    {
        if (!examineMenu.activeInHierarchy)
        {
            examineMenu.SetActive(true);
            talkMenu.SetActive(false);
        }
        else
        {
            examineMenu.SetActive(false);
        }
    }
    public void Talk()
    {
        if (!talkMenu.activeInHierarchy)
        {
            talkMenu.SetActive(true);
            examineMenu.SetActive(false);
        }
        else
        {
            talkMenu.SetActive(false);
        }
    }
    #endregion
}