using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int score = 0;

    [SerializeField] Text scoreText;

    [SerializeField] GameObject gameOverPanel;
    [SerializeField] Text gameOverScore;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        gameOverPanel.SetActive(false);
        score = 0;
        scoreText.text = "0";
    }

    void Update()
    {
        score = (int)Time.timeSinceLevelLoad;
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverScore.text = "Score :\n" + scoreText.text;
        gameOverPanel.SetActive(true);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
    public void Retry()
    {
        SceneManager.LoadScene("MainLevel");
        Time.timeScale = 1;
    }
}
