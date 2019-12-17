using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject gameOverPanel;
    public Text scoreText;
    private string mainScene = "MainScene";
    private string menuScene = "MenuScene";
    private int score = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void GameOver()
    {
        ObstacleSpawner.instance.gameOver = true;
        StopScrolling();
        gameOverPanel.SetActive(true);
    }

    private void StopScrolling()
    {
        TextureScroll[] scrollingObjects = FindObjectsOfType<TextureScroll>();

        foreach (TextureScroll item in scrollingObjects)
        {
            item.scroll = false;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(mainScene);
    }


    public void Menu()
    {
        SceneManager.LoadScene(menuScene);
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
