using UnityEngine;
using System.Collections;

public class Shredder : MonoBehaviour {

	public GameObject popupTextParentPrefab;

	void Start() {
		FloatingTextController.Initialize ();
	}

	void OnTriggerEnter2D(Collider2D col) {
		Destroy (col.gameObject);

		if (col.gameObject.tag == "Enemy") {

			ScoreCounter.score -= ScoreCounter.years * 3;
			FloatingTextController.CreateFloatingText ("-3", popupTextParentPrefab.transform);

		}
	}
}
