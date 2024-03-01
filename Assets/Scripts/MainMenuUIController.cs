using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour
{
        public Button playButton;
        public Button creditButton;
        public Button exitButton;
        
        private void Start()
        {
            playButton.onClick.AddListener(PlayGame);
            creditButton.onClick.AddListener(Credit);
            exitButton.onClick.AddListener(ExitGame);
        }

        public void PlayGame()
        {
            SceneManager.LoadScene("PinBall_Game");
        }

        public void Credit()
        {
            SceneManager.LoadScene("Credit");
        }
        public void ExitGame()
        {
            Application.Quit();
        }
}
