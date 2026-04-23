using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState currentState;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        currentState = GameState.Playing;
    }

    void Update()
    {
        switch (currentState)
        {
            case GameState.MainMenu:
            Debug.Log("Main Menu");
            break;
            case GameState.Playing:
            Debug.Log("Playing");
            break;
            case GameState.Paused:
            Time.timeScale = 0f;
            Debug.Log("Paused");
            break;
            case GameState.GameOver:
            Debug.Log("Game Over");
            break;
            default:
            Debug.Log("Unknown State");
            break;
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        currentState = GameState.Paused;
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        currentState = GameState.GameOver;
    }
    
}