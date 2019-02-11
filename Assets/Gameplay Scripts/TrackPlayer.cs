using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPlayer : MonoBehaviour {

	public Transform target;
	public float speed;
	public float trackDistance;
	private float targetY;

	private void Start() {
		targetY = target.position.y;
	}
	// Update is called once per frame
	void Update() {
		Vector3 targetPos = new Vector3(target.position.x, targetY, target.position.z);
		transform.LookAt(targetPos, Vector3.up);
		Vector3 trackedPos = transform.forward * speed * Time.deltaTime;
		if (Vector3.Distance(targetPos, transform.position) < trackDistance) {
			transform.position += new Vector3(trackedPos.x, 0, trackedPos.z);
		}
	}

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Hammer") && Input.GetButton("Fire1")) {
			Destroy(gameObject);
		}
	}
}