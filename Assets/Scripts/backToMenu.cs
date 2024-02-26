using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class backToMenu : MonoBehaviour
{
    public Button backToMenuButton;
    void Start()
    {
        backToMenuButton.onClick.AddListener(kembali);
    }

    // Update is called once per frame
   private void kembali()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
