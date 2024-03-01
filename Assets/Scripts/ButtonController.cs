using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button hotkeys;
    public GameObject clickMe;
    public GameObject dropHotkeys;
    public Button restartButton;
    public Button mainMenuButton;
    private
    // Start is called before the first frame update
    void Start()
    {
        hotkeys.onClick.AddListener(Hotkeys);
        restartButton.onClick.AddListener(Restart);
        mainMenuButton.onClick.AddListener(MainMenu);
        clickMe.SetActive(true);
   
    }
    public void Hotkeys()
    {
        clickMe.SetActive(false);
        if (!dropHotkeys.activeSelf)
        {
            dropHotkeys.SetActive(true);
        }
        else
        {
            dropHotkeys.SetActive(false);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("PinBall_Game");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
