using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public static GameManager gm;
	public GameObject player;

	private enum gameStates {Playing, BeatLevel, FailLevel, GameOver};
	private gameStates gameState = gameStates.Playing;

	public bool levelBeaten = false;
	public bool levelFailed = false;
	public GameObject beatLevelCanvas;
	public GameObject failLevelCanvas;
	public AudioSource backgroundMusic;
	public AudioClip beatLevelSFX;
	public AudioClip failLevelSFX;

	void Start () {
		if (gm == null) 
			gm = gameObject.GetComponent<GameManager>();

		if (player == null)
			player = GameObject.FindWithTag("Player");

		beatLevelCanvas.SetActive (false);
	}

	void Update () {
		switch (gameState)
		{
			case gameStates.Playing:
				if (levelBeaten) {
					// update gameState
					gameState = gameStates.BeatLevel;

					// hide the player so game doesn't continue playing
					player.SetActive (false);

					// switch which GUI is showing			
					beatLevelCanvas.SetActive (true);
				} else if (levelFailed) {
					gameState = gameStates.FailLevel;

					// hide the player so game doesn't continue playing
					player.SetActive (false);

					// switch which GUI is showing
					failLevelCanvas.SetActive (true);
				}
				break;
			case gameStates.BeatLevel:
				backgroundMusic.volume -= 0.01f;
				if (backgroundMusic.volume<=0.0f) {
					AudioSource.PlayClipAtPoint (beatLevelSFX,gameObject.transform.position,0.5f);
					
					gameState = gameStates.GameOver;
				}
				break;
			case gameStates.FailLevel:
				backgroundMusic.volume -= 0.01f;
				if (backgroundMusic.volume<=0.0f) {
					AudioSource.PlayClipAtPoint (failLevelSFX,gameObject.transform.position,0.5f);

					gameState = gameStates.GameOver;
				}
				break;
			case gameStates.GameOver:
				// nothing
				break;
		}
	}

	public void beatLevel() {
		levelBeaten = true;
	}

	public void failLevel() {
		levelFailed = true;		
	}
}
