using UnityEngine;
using System.Collections;

public class globalScripts : MonoBehaviour {

	//Loads the given level after a set delay
	public static IEnumerator loadNextLevel(float delay, int level){
		yield return new WaitForSeconds (delay);
		Application.LoadLevel (level);
	}


}
