using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveQuiz : MonoBehaviour
{
    public string scenePath;

    public void Leave()
    {
        SceneManager.LoadScene(scenePath);
    }
}
