using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {

	public Rigidbody2D rb;
	public Renderer rend;
	public AudioClip death;
	public GameObject smokePrefab;

	void Start() {
		rb = GetComponent<Rigidbody2D> ();
		rend = GetComponent<Renderer> ();
	}

	void SmokePuff() {
		Instantiate (smokePrefab, transform.position, Quaternion.identity);
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.tag == "FriendlyProjectile") {
			GetComponent<AudioSource>().Play ();
			rend.enabled = false;
			SmokePuff ();
			Destroy (gameObject, death.length);
			ScoreCounter.score += ScoreCounter.years;
		}
	}
}
