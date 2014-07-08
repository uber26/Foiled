using UnityEngine;
using System.Collections;

public class loadTitleAuto : MonoBehaviour {

	void Start () {
		StartCoroutine (autoSwitchScreen ());
	}

	void Update () {
		if (Input.anyKeyDown) {
			StopCoroutine ("autoSwitchScreen");
			StartCoroutine (globalScripts.loadNextLevel (0.1f, 2));
		}
	}

	IEnumerator autoSwitchScreen(){
		TextMesh timer = GameObject.Find ("Countdown").GetComponent<TextMesh>();
		for (int i = 20; i > 0; i--) {
			timer.text = "Go to Level Select in: " + i.ToString();
			yield return new WaitForSeconds (1);
		}
		StartCoroutine (globalScripts.loadNextLevel (0.1f, 2));
	}


}
