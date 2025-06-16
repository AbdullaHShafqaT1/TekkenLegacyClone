using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private int playerScore = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Debug.LogWarning("Another GameManager instance detected! Destroying the new one.");
            Destroy(gameObject);
        }
    }

    public void AddScore(int points)
    {
        playerScore += points;
        Debug.Log("Player Score Updated: " + playerScore);
    }

    public int GetScore()
    {
        return playerScore;
    }

}