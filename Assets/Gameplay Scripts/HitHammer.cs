using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitHammer : MonoBehaviour {

	Vector3 startingRot;
	Vector3 startingPos;
	Vector3 hammerHitRot;

	private void Start() {
		startingRot = transform.localEulerAngles;
		startingPos = transform.localPosition;
		Debug.Log(startingPos);
		hammerHitRot = new Vector3(90, 0, 0);
	}

	// Update is called once per frame
	void Update() {
		if (Input.GetButton("Fire1")) {
			transform.localEulerAngles = hammerHitRot;
			transform.localPosition = new Vector3(0, 0.5f, startingPos.z);
			Debug.Log(transform.localEulerAngles);
		} else {
			transform.localEulerAngles = startingRot;
			transform.localPosition = startingPos;
		}
	}
}