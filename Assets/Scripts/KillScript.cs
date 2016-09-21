using UnityEngine;
using System.Collections;

public class KillScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			GameObject gameManager = GameObject.Find ("GameManager");
			gameManager.GetComponent<GameManager>().failLevel();
		}
	}
}
