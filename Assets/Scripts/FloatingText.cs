using UnityEngine;
using System.Collections;

public class FloatingText : MonoBehaviour {

	public Animator animator;

	void Start() {
		AnimatorClipInfo[] clipInfo = animator.GetCurrentAnimatorClipInfo (0);
		Destroy (gameObject, clipInfo[0].clip.length);
	}

}
