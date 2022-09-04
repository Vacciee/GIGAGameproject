using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    // Score is the total amount of points the player has gained during the quiz
    public static float score;
    // Reward is the amount of points the player gets each time they answer correctly: each time they answer wrong it gets reduced.
    public float reward;

    void Start()
    {
        score = 0f;
        reward = 1000f;
    }

    public void AddToScore()
    {
        score += reward;
        Debug.Log("Adding reward to the total score! Score now " + score);
        reward = 1000f;
    }

    public void ReducePoints()
    {
        reward *= 0.87f;
        Mathf.Round(reward);
        Debug.Log("Reduced points, possible reward is at " + reward);
    }
}