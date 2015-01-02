using UnityEngine;
using System.Collections;

public class animationLogo : MonoBehaviour {

	public Texture[] frames = new Texture[66];
	public string next;
	private int frame;
	private bool playing, wait, fadeIn, fadeOut, done;	
	private Color alpha;

	// Use this for initialization
	void Start () {
	 alpha = Color.gray;
	 alpha.a = 0f;
	 frame = 0;

	 guiTexture.texture = frames[frame];
	 wait = false;
	 playing = false;
	 fadeIn = true;
	 fadeOut = false;
	 done = false;
	 
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Rect temp = new Rect(-Screen.width/2,-Screen.width*0.5625f/2, Screen.width,Screen.width*0.5625f);
		guiTexture.pixelInset = temp;


		if(fadeIn){
			alpha.a += 0.04f;
			guiTexture.color = alpha;
			if (alpha.a >= 0.5f){
				fadeIn = false;
				playing = true;
			}
		}
		if(playing){
			 guiTexture.texture = frames[frame];

			 if (wait){
			 	frame++; wait = false;
			 }
			 else {
			 	wait = true;
			 }

			 if (frame == 65){
			 	playing = false;
			 	fadeOut = true;
			 }
		}
		if(fadeOut){
			alpha.a -= 0.01f;
			guiTexture.color = alpha;
			if (alpha.a <= 0f){
				fadeOut = false;
				done = true;
			}
		}
		if(done){
			Application.LoadLevel(next);
		}

	}

}
