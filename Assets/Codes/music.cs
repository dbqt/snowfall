using UnityEngine;
using System.Collections;

public class music : MonoBehaviour {
//singleton
	public static music instance = null;

	// Use this for initialization
	void Awake () {
		if(instance != null && instance != this){
			Destroy(this.gameObject);
			return;
		}
		else{
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}
	
}
