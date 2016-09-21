using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System.Collections;

public class BallController : MonoBehaviour {

	public float force = 500f;
	public int multiplier = 1;

	void Update () {
		float horizontalMove = CrossPlatformInputManager.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D> ().AddForce (new Vector2(horizontalMove, 0) * force * multiplier * Time.deltaTime);
	}
}
