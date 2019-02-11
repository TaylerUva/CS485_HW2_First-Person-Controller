using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPlayer : MonoBehaviour {

	public Transform target;
	public float speed;
	public float trackDistance;
	// Update is called once per frame
	void Update() {
		Vector3 targetPos = new Vector3(target.position.x, 1, target.position.z);
		transform.LookAt(targetPos, Vector3.up);
		Vector3 trackedPos = transform.forward * speed * Time.deltaTime;
		if (Vector3.Distance(targetPos, transform.position) < trackDistance) {
			transform.position += new Vector3(trackedPos.x, 0, trackedPos.z);
		}
	}
}