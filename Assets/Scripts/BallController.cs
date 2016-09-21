using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	public float force = 500f;

	void Update () {
		float horizontalMove = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D> ().AddForce (new Vector2 (horizontalMove, 0) * force * Time.deltaTime);
	}
}
