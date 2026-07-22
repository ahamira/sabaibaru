using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject gameOverPanel;
    public GameObject gameClearPanel;

    bool isGameClear = false;
    bool isGameOver = false;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if ((isGameOver || isGameClear) &&
            Keyboard.current.rKey.wasPressedThisFrame)
        {
            Time.timeScale = 1f;

            SceneManager.LoadScene(
                SceneManager.GetActiveScene().buildIndex
            );
        }
    }
    public void GameClear()
    {
        gameClearPanel.SetActive(true);

        isGameClear = true;

        Time.timeScale = 0f;
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);

        isGameOver = true;

        Time.timeScale = 0f;
    }
}