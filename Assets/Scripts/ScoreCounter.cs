using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour {

	public static int score = 0;
	public static int years = 1;
	public Text scoreText;

	void Update() {
		scoreText.text = "YEARS: " + score;

		if (score < 0) {
			SceneManager.LoadScene ("Win");
		}
	}

}
