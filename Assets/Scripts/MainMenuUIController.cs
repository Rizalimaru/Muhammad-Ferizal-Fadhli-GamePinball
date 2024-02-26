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
    void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        creditButton.onClick.AddListener(CreditGame);
        exitButton.onClick.AddListener(ExitGame);
    }

    // Update is called once per frame
   public void PlayGame()
    {
        SceneManager.LoadScene("MasterScene");
    }

    private void CreditGame()
    {
        SceneManager.LoadScene("Credit");
    }
    private void ExitGame()
    {
        Application.Quit();
    }
}
