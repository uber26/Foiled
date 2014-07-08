using UnityEngine;
using System.Collections;

public class doNotDestroy : MonoBehaviour {

	private static bool created = false;

	//On Awake, creates a persistant object which can be used for game management.
	void Awake () {

		if (!created) {
			DontDestroyOnLoad(this.gameObject);
			created = true;
		} else {
			Destroy (this.gameObject);
		}
	
	}
	
}
