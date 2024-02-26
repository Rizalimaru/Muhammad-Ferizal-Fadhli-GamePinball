using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour
{

    public Button mainMenuButton;
    private void Start()
        {
                // setup event saat button di klik
            mainMenuButton.onClick.AddListener(MainMenu);
        }

    public void MainMenu()
        {
            SceneManager.LoadScene("MainMenu");
    }
}
