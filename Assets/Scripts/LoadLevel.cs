using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {
	
	public string LevelToLoad;
	
	public void loadLevel() {
		//Load the level from LevelToLoad
		SceneManager.LoadScene(LevelToLoad, LoadSceneMode.Single);
	}
}
