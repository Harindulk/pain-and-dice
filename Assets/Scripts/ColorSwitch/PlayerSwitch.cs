using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerSwitch : MonoBehaviour {

	int timeTOPlay = DiceCheckZoneScript.result - 1;
	[SerializeField] private TMP_Text levelsToCompleteText;
	[SerializeField] private GameObject winPanel;
	private bool restartGame = false;
    
	public float jumpForce = 10f;
	public Rigidbody2D rb;
	public SpriteRenderer sr;

	public string currentColor;

	public Color colorCyan;
	public Color colorYellow;
	public Color colorMagenta;
	public Color colorPink;

	void Start ()
	{
		SetRandomColor();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
		{
			rb.velocity = Vector2.up * jumpForce;
		}
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "ColorChanger" && restartGame == false)
		{
			SetRandomColor();
			Destroy(col.gameObject); 
			return;
		}

		if (col.tag == "won")
		{
			levelsToCompleteText.text = timeTOPlay.ToString();
			winPanel.SetActive(true);
			DiceCheckZoneScript.result = timeTOPlay;
			restartGame = true;
            
			if (timeTOPlay == 0)
			{
				SceneManager.LoadScene("gameover");
			}
            
		}

		if (col.tag != currentColor && restartGame == false)
		{
			Debug.Log("GAME OVER!");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	void SetRandomColor ()
	{
		int index = Random.Range(0, 4);

		switch (index)
		{
			case 0:
				currentColor = "Cyan";
				sr.color = colorCyan;
				break;
			case 1:
				currentColor = "Yellow";
				sr.color = colorYellow;
				break;
			case 2:
				currentColor = "Magenta";
				sr.color = colorMagenta;
				break;
			case 3:
				currentColor = "Pink";
				sr.color = colorPink;
				break;
		}
	}

	public void loadAnotherLevel() //level loader
	{
		int index = Random.Range(2, 10);
		SceneManager.LoadScene(index);
	}
}
