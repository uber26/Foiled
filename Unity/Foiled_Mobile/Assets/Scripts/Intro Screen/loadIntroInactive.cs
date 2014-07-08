using UnityEngine;
using System.Collections;

public class loadIntroInactive : MonoBehaviour {

	private Vector3 _mouseDelta;
	private float last_move;
	public TextMesh timer;

	void Start() {
		timer = GameObject.Find ("Timer").GetComponent<TextMesh> ();
	}

	// Use this for initialization
	void Update () {
				if (Vector3.Magnitude (Input.mousePosition - _mouseDelta) > 0.0)
						last_move = Time.time;

				_mouseDelta = Input.mousePosition;

				if ((Mathf.Abs (Time.time - last_move)) > 10.0f) {
						last_move = 0.0f;
						StartCoroutine (globalScripts.loadNextLevel (0.1f, 1));
				} else {
						timer.text = "If inactive, revert to Intro Movie in " + Mathf.Round(Mathf.Abs(10 - Mathf.Abs (Time.time - last_move))).ToString ();
				}
		}
}
