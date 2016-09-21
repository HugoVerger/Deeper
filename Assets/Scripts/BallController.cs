using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	public float force = 500f;
	private Vector2 direction = new Vector2 (0,0);

	void Update () {
		float horizontalMove = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D> ().AddForce (direction * force * Time.deltaTime);
	}

	public void moveLeft () {
		direction = Vector2.left;
	}

	public void moveRight() {
		direction = Vector2.right;
	}
}
