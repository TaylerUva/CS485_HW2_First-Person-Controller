using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WarpNextLevel : MonoBehaviour {

	public int nextSceneIndex;

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Player")) {
			if (nextSceneIndex >= 1) {
				SceneManager.LoadScene(nextSceneIndex);
			}
		}
	}
}