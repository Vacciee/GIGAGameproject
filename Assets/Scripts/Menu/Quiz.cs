using UnityEngine;
using UnityEngine.SceneManagement;

public class Quiz : MonoBehaviour
{
    GameManager gameManager;
    [SerializeField] int answer = 0;

    public void update()
    {
        if (answer == 1)
        {
            gameManager.cargo += 1; // correct anwser adds to cargo in Game Manager.
            answer = 0;
        }
        if (answer == 0)
        {
            return;
        }
    }
    public void CorrectAnwser()
    {
        answer = 1;
        SceneManager.LoadScene("Map");
    }
    public void WrongAnwser()
    {
        answer = 0;
    }
}