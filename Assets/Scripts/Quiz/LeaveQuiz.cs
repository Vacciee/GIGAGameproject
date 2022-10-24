using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveQuiz : MonoBehaviour
{
    public void Leave()
    {
        SceneManager.LoadScene("Map");
    }
}
