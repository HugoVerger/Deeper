using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	public float speed = 0.050f;
	public GameObject ball;
	private bool cameraStarted = false;

	void Start() {
		if (ball == null) {
			ball = GameObject.Find ("Ball");
		}
		cameraStarted = false;
		ball.GetComponent<Rigidbody2D> ().isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (!cameraStarted && (CrossPlatformInputManager.GetAxis ("Horizontal") > 0 || CrossPlatformInputManager.GetAxis ("Horizontal") < 0)) {
			cameraStarted = true;
			ball.GetComponent<Rigidbody2D> ().isKinematic = false;
		} else if (cameraStarted) {
			transform.Translate (new Vector3 (0, -speed, 0));
		}
	}
}
