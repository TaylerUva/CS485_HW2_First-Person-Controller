using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckEnemyContact : MonoBehaviour {
	public int level;

	private void OnCollisionEnter(Collision other) {
		if (other.gameObject.CompareTag("Enemy")) {
			GetComponent<LoadScene>().LoadByIndex(level);
		}
	}
}