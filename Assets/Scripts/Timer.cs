using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public static float time;
	public static float bestTime = 0;
	public Text timerText;
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		timerText.text = "TIME: " + time.ToString("f0");

		if (time > bestTime) {
			bestTime = time;
		}
	}
}
