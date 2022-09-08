using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizPauseScript : MonoBehaviour
{

    public GameObject pauseMenu;

    void Awake()
    {
        pauseMenu = GameObject.Find("PauseMenu");
    }

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    public void PauseQuiz()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeQuiz()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }


}
