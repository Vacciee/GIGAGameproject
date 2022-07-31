using UnityEngine;
using UnityEngine.SceneManagement;


public class Load : MonoBehaviour
{
    #region Variables;
    public GameObject examineMenu;
    public GameObject talkMenu;
    int index;
    #endregion

    #region Scene Loading
    // Main menu Control script
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 0f; // Pauses
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Map");
        Time.timeScale = 1f; // Unpauses
    }
    public void LoadGuide()
    {
        SceneManager.LoadScene("Guide");
    }
    public void LoadOptions()
    {
        SceneManager.LoadScene("Options");
    }
    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void LoadQuiz()
    {
        SceneManager.LoadScene("Quiz");
    }
    public void ExitApplication() // Quit Button
    {
        Application.Quit();
    }

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

    #region Levels
    // Levels
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f; // Unpauses
    }
    #endregion
}