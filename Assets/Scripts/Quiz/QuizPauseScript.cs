using UnityEngine;

public class QuizPauseScript : MonoBehaviour
{

    [HideInInspector] public GameObject pauseMenu;
    [HideInInspector] public GameObject leaveConfirm;

    void Awake()
    {
        leaveConfirm = GameObject.Find("LeaveConfirm");
        pauseMenu = GameObject.Find("PauseMenu");
    }

    void Start()
    {
        leaveConfirm.SetActive(false);
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

    public void LeaveConfirm()
    {
        leaveConfirm.SetActive(true);
    }

    public void LeaveCancel()
    {
        leaveConfirm.SetActive(false);
    }

}