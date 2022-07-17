using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour {

	public static int PinCount;

	public TMP_Text text;

	void Start ()
	{
		PinCount = 0;
	}

	void Update ()
	{
		text.text = PinCount.ToString();
	}

}
