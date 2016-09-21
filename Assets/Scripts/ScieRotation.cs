using UnityEngine;
using System.Collections;

public class ScieRotation : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		GetComponent<Transform>().Rotate (0, 0, -425 * Time.deltaTime);
	}
}
