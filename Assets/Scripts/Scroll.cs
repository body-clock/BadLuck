using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	public float speed = 0.5f;
	public Renderer rend;
	
	void Update () {
		rend = GetComponent<Renderer> ();
		Vector3 offset = new Vector3 (0, Time.time * speed);

		rend.material.mainTextureOffset = offset;

		speed += .00001f;
	}
}
