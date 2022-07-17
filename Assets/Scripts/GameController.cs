using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public DiceScript diceScript;
    [SerializeField] private GameObject homePanel;

    public void loadLevel()  //level loader
    {
        int index = Random.Range(2, 10);
        SceneManager.LoadScene(index);
    }

    public void quit()
    {
        Application.Quit();
    }
    public void GitHub()
    {
        Application.OpenURL("https://github.com/Harindulk");
    }
    public void Twitter()
    {
        Application.OpenURL("https://twitter.com/Harindu_Fonseka");
    }
    public void LinkedIN()
    {
        Application.OpenURL("https://www.linkedin.com/in/harindulk/");
    }
    public void Youtube()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCRyQGxzCgFb5wmsp1XAlWpQ");
    }
    public void Website()
    {
        Application.OpenURL("https://www.harindu.dev/");
    }
    public void discord()
    {
        Application.OpenURL("https://discord.gg/MFXRfMeFB7");
    }
    public void itch()
    {
        Application.OpenURL("https://harindulk.itch.io/");
    }

    public void Restart()
    {
        DiceCheckZoneScript.keyPressed = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
    }

    void Pause()
    {
        Time.timeScale = 0f;
    }

    void Resume()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void play()
    {
        homePanel.SetActive(false);
        GameObject.Find("Dice").GetComponent<DiceScript>().enabled = true;
    }

}
