using UnityEngine;
using System.Collections;

public class FakeSticky : MonoBehaviour {

	public int multiplier = 5;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			other.GetComponent<BallController> ().multiplier = multiplier;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.tag == "Player")
		{
			other.GetComponent<BallController> ().multiplier = 1;
		}
	}
}
