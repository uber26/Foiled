using UnityEngine;
using System.Collections;

public class loadIntroAuto : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		StartCoroutine(globalScripts.loadNextLevel(3.0f,1));

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
