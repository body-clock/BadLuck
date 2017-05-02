using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinText : MonoBehaviour {

	public Text finalScore;
	public Text highScore;

	// Use this for initialization
	void Start () {
		finalScore.text = "YOU INFLICTED BAD LUCK FOR " + Timer.time.ToString ("f0") + " SECONDS!";
		highScore.text = "HIGH SCORE: " + Timer.bestTime.ToString("f0") + " SECONDS!";
	}

}
