using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class aaManager : MonoBehaviour {

	int timeTOPlay = DiceCheckZoneScript.result -1;

	private bool gameHasEnded = false;
	public aaRotator rotator;
	public Spawner spawner;
	public Animator animator;

	public int winAmount;
    public int range1, range2;

    [SerializeField] private TMP_Text needToWin;
    [SerializeField] private TMP_Text levelstoCompleteText;
	[SerializeField] private GameObject winPanel;

    private void Start()
    {
		winAmount = Random.Range(range1, range2);

		needToWin.text = winAmount.ToString();
		Debug.Log(timeTOPlay);
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
    
    public void Update()
    {
		if (Score.PinCount == winAmount)
		{
			animator.SetTrigger("gameWon");
			Debug.Log(timeTOPlay);
			levelstoCompleteText.text = timeTOPlay.ToString();
			DiceCheckZoneScript.result = timeTOPlay;


			if (timeTOPlay == 0)
			{
				SceneManager.LoadScene("gameover");                
			}
		}
	}

    public void levelCompleted()
    {
		winPanel.SetActive(true);
		rotator.enabled = false;
		spawner.enabled = false;
	}

    public void RestartLevel ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
    
    public void loadAnotherLevel()  //level loader
	{
		int index = Random.Range(2, 10);
		SceneManager.LoadScene(index);
	}

}
