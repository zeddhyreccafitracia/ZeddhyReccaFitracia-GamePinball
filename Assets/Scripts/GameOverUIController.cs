using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour
{
    public TMP_Text finalScoreText;
    public ScoreManager scoreManager;

    public Button restartButton;
    public Button mainMenuButton;

    private void Start()
    {
        restartButton.onClick.AddListener(RestartGame);
        mainMenuButton.onClick.AddListener(MainMenu);
        finalScoreText.text = scoreManager.score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("PinBall_Game");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
