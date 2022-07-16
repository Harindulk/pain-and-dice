using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiceNumberTextScript : MonoBehaviour {

	TMP_Text text;
	public static int diceNumber;

	// Use this for initialization
	void Start () {
		text = GetComponent<TMP_Text> ();
	}
	
	// Update is called once per frame
	void Update () {
        
		text.text = diceNumber.ToString ();
	}
}
