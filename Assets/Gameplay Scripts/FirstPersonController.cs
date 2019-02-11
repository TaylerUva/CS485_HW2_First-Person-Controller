using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour {

	public float speed = 5;
	public float rotationSpeed = 5;

	public Rigidbody body;
	private Vector3 rotation = Vector3.zero;

	// Update is called once per frame
	void Update() {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		movement = movement.normalized;
		if (movement.x != 0)
			body.MovePosition(body.position + transform.right * movement.x * speed * Time.deltaTime);
		if (movement.z != 0)
			body.MovePosition(body.position + transform.forward * movement.z * speed * Time.deltaTime);

		rotation.x = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * rotationSpeed;
		rotation.y += Input.GetAxis("Mouse Y") * rotationSpeed;
		transform.localEulerAngles = new Vector3(-rotation.y, rotation.x, 0);
	}
}