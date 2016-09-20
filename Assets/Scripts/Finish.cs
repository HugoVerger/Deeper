using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			GameObject gameManager = GameObject.Find ("GameManager");
			gameManager.GetComponent<GameManager>().beatLevel();
		}
	}
}