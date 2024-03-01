using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditUIController : MonoBehaviour
{
    public Button backButton;
    
    private void Start()
    {
        backButton.onClick.AddListener(BackMainMenu);
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
