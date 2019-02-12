﻿using System.Collections;
using UnityEngine;

public class Rotator : MonoBehaviour {

	public Vector3 rotation = new Vector3(15, 30, 45);

	void Update() {
		transform.Rotate(rotation * Time.deltaTime);
	}
}