using UnityEngine;
using System.Collections;

public class logo : MonoBehaviour {


private Color alpha;
private bool fadeIn, fadeOut;
	// Use this for initialization
	void Start () {
	fadeIn = true;
	fadeOut = false;
	alpha = Color.gray;
	alpha.a = 0f;
	}
	
	// Update is called once per frame
	void Update () {

		if(fadeIn){
			alpha.a += 0.04f;
			guiTexture.color = alpha;
			if (alpha.a >= 0.5f){
				fadeIn = false;
				Invoke("Unload",2f);
			}
		}
		if(fadeOut){
			alpha.a -= 0.04f;
			guiTexture.color = alpha;
			if (alpha.a <= 0f){
				fadeOut = false;
			}
		}
	}

	void Unload(){
		fadeOut = true;
	}
}
