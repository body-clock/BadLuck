using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float playerSpeed = 5;
	public GameObject lightningPrefab;
	public float lightningSpeed = 7;
	public float firingRate = 0.2f;

	private Rigidbody2D rb;
	private float xmin = -3;
	private float xmax = 3;
	private GameObject lightning;
	private int shotCounter = 0;

	void Fire() {
		Vector3 offset = new Vector3 (0, 1, 0);
		lightning = Instantiate(lightningPrefab, transform.position + offset, Quaternion.identity) as GameObject;
		rb = lightning.GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector3 (0, lightningSpeed, 0);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 move = new Vector3 (Input.GetAxis ("Horizontal"), 0, 0);
		transform.position += move * playerSpeed * Time.deltaTime;

		float newX = Mathf.Clamp (transform.position.x, xmin, xmax);
		Vector3 pos = transform.position;
		pos.x = newX;
		transform.position = pos;

		if (Input.GetKeyDown(KeyCode.Space)) {
			Fire ();
			shotCounter++;
			GetComponent<AudioSource>().Play ();
		}

	}
			
}
