using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour {

	public float speed = 5;
	public float jumpHeight = 1;
	public float rotationSpeed = 5;

	private Rigidbody rb;
	private Vector3 rotation = Vector3.zero;
	private bool isGrounded;

	// Start is called before the first frame update
	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		movement = movement.normalized;
		if (movement.x != 0)
			rb.MovePosition(rb.position + transform.right * movement.x * speed * Time.deltaTime);
		if (movement.z != 0)
			rb.MovePosition(rb.position + transform.forward * movement.z * speed * Time.deltaTime);

		rotation.x = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * rotationSpeed;
		rotation.y += Input.GetAxis("Mouse Y") * rotationSpeed;
		transform.localEulerAngles = new Vector3(-rotation.y, rotation.x, 0);
	}

	private void Update() {
		if (Input.GetButtonDown("Jump") && isGrounded) {
			rb.AddForce(Vector3.up * Mathf.Sqrt(jumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
			isGrounded = false;
		}
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.CompareTag("Ground")) {
			isGrounded = true;
		}
	}

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Enemy")) {
			GetComponent<LoadScene>().LoadByIndex(2);
		}
	}
}