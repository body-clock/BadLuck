using UnityEngine;
using System.Collections;

public class FloatingTextController : MonoBehaviour {

	private static FloatingText popupText;
	private static GameObject canvas;

	public static void Initialize() {
		canvas = GameObject.Find ("Canvas");
		if (!popupText) {
			popupText = Resources.Load<FloatingText> ("PopupTextParent");
		}
	}

	public static void CreateFloatingText(string text, Transform location) {
		FloatingText instance = Instantiate (popupText);
		Vector2 screenPosition = Camera.main.WorldToScreenPoint (location.position);
		instance.transform.SetParent (canvas.transform, true);
		instance.transform.position = screenPosition;
	}

}
