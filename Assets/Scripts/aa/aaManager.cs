using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class aaManager : MonoBehaviour {

	int result = DiceCheckZoneScript.result;
	int low = 1;
	static int levelstoComplete;
	private bool gameHasEnded = false;
	public aaRotator rotator;
	public Spawner spawner;
	public Animator animator;
	public int winAmount;

	[SerializeField] private TMP_Text needToWin;
    [SerializeField] private TMP_Text levelstoCompleteText;
	[SerializeField] private GameObject winPanel;

    private void Start()
    {
		needToWin.text = winAmount.ToString();
    }

    public void EndGame ()
	{
		if (gameHasEnded)
			return;

		rotator.enabled = false;
		spawner.enabled = false;

		animator.SetTrigger("EndGame");

		gameHasEnded = true;
	}

	public void RestartLevel ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
	}

	public void Update()
	{
		if (Score.PinCount == winAmount)
        {
			result = result - 1;
			checkIsWon();
			winPanel.SetActive(true);
			rotator.enabled = false;
			spawner.enabled = false;
			animator.SetTrigger("gameWon");
			levelstoCompleteText.text = result.ToString();
		}
	}

    public void checkIsWon()
    {
        if (result == 0)
        {
			SceneManager.LoadScene("gameover");
        }
	}
    
    public void loadAnotherLevel()
    {
		int index = Random.Range(1, 2);
		SceneManager.LoadScene(index);
	}

}
