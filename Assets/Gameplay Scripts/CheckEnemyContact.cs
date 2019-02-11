using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckEnemyContact : MonoBehaviour {
	private void OnCollisionEnter(Collision other) {
		if (other.gameObject.CompareTag("Enemy")) {
			GetComponent<LoadScene>().LoadByIndex(2);
		}
	}
}