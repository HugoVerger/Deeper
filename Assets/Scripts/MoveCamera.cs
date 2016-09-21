using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	public float speed = 0.150f;
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (0, -speed, 0));
	}
}
