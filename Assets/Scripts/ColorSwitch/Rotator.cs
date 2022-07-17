using UnityEngine;

public class Rotator : MonoBehaviour {

	public float speed_3 = 100f;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0f, 0f, speed_3 * Time.deltaTime);
	}
}
