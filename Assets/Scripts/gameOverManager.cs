using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverManager : MonoBehaviour
{
    public void restartGameOver()
    {
        SceneManager.LoadScene("Roll the Dice");
    }
    public void quit()
    {
        SceneManager.LoadScene(0);
    }
}
