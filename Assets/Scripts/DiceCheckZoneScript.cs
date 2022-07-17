using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DiceCheckZoneScript : MonoBehaviour {

	Vector3 diceVelocity;
    public static int keyPressed;
	public bool secondtime = false;
    public bool scorePanelActive = false;
    static int firstNumber;
    static int secondNumber;
    public static int result;
    [SerializeField] private GameObject secondPanel;
    public GameObject havetoCompletePanel;
    [SerializeField] private TMP_Text havetoCompleteScore;
    [SerializeField] private TMP_Text firstDice;
    [SerializeField] private TMP_Text secondDice;

    private void Start()
    {
        havetoCompletePanel.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate () {
		diceVelocity = DiceScript.diceVelocity;
    }

	void OnTriggerStay(Collider col)
	{
        
		if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f && keyPressed == 1 && secondtime == false)
		{
			switch (col.gameObject.name)
			{
				case "Side1":
					DiceNumberTextScript.diceNumber = 4;
					firstNumber = 4;
                    secondtime = true;
                    keyPressed = 0;
                    DiceScript.disableInput = true;
                    StartCoroutine(secondmode()); 
                    break;
				case "Side2":
					DiceNumberTextScript.diceNumber = 5;
					firstNumber = 5;
                    secondtime = true;
                    keyPressed = 0;
                    DiceScript.disableInput = true;
                    StartCoroutine(secondmode());
                    break;
				case "Side3":
					DiceNumberTextScript.diceNumber = 6;
					firstNumber = 6;
                    secondtime = true;
                    keyPressed = 0;
                    DiceScript.disableInput = true;
                    StartCoroutine(secondmode());
                    break;
				case "Side4":
					DiceNumberTextScript.diceNumber = 1;
					firstNumber = 1;
                    secondtime = true;
                    keyPressed = 0;
                    DiceScript.disableInput = true;
                    StartCoroutine(secondmode());
                    break;
				case "Side5":
					DiceNumberTextScript.diceNumber = 2;
					firstNumber = 2;
                    secondtime = true;
                    keyPressed = 0;
                    DiceScript.disableInput = true;
                    StartCoroutine(secondmode());
                    break;
				case "Side6":
					DiceNumberTextScript.diceNumber = 3;
					firstNumber = 3;
                    secondtime = true;
                    keyPressed = 0;
                    DiceScript.disableInput = true;
                    StartCoroutine(secondmode());
                    break;
			}
            firstDice.text = firstNumber.ToString();
        }

        if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f && keyPressed == 1 && secondtime == true)
        {
      
            switch (col.gameObject.name)
            {
                case "Side1":
                    DiceNumberTextScript.diceNumber = 4;
                    secondNumber = 4;
                    scorePanelActive = true;
                    StartCoroutine(scorPanele());
                    havetoCompletePanel.SetActive(true);
                    break;
                case "Side2":
                    DiceNumberTextScript.diceNumber = 5;
                    secondNumber = 5;
                    scorePanelActive = true;
                    StartCoroutine(scorPanele());
                    havetoCompletePanel.SetActive(true);
                    break;
                case "Side3":
                    DiceNumberTextScript.diceNumber = 6;
                    secondNumber = 6;
                    scorePanelActive = true;
                    StartCoroutine(scorPanele());
                    havetoCompletePanel.SetActive(true);
                    break;
                case "Side4":
                    DiceNumberTextScript.diceNumber = 1;
                    secondNumber = 1;
                    scorePanelActive = true;
                    StartCoroutine(scorPanele());
                    havetoCompletePanel.SetActive(true);
                    break;
                case "Side5":
                    DiceNumberTextScript.diceNumber = 2;
                    secondNumber = 2;
                    scorePanelActive = true;
                    StartCoroutine(scorPanele());
                    havetoCompletePanel.SetActive(true);
                    break;
                case "Side6":
                    DiceNumberTextScript.diceNumber = 3;
                    secondNumber = 3;
                    scorePanelActive = true;
                    StartCoroutine(scorPanele());
                    havetoCompletePanel.SetActive(true);
                    break;
            }
            secondDice.text = secondNumber.ToString();
        }
    }
    IEnumerator secondmode()
    {
        yield return new WaitForSeconds(0.5f);
        secondPanel.SetActive(true);
        
        yield return new WaitForSeconds(3f);
        DiceScript.disableInput = false;
    }

    IEnumerator scorPanele()
    {
        yield return new WaitForSeconds(0.5f);
        result = firstNumber + secondNumber;
        havetoCompleteScore.text = result.ToString();
        Cursor.visible = true;
    }
}
