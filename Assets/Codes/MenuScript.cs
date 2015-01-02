using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
	public string game, about;

	public void PlayGame(){
		Application.LoadLevel(game);
	}

	public void About(){
		Application.LoadLevel(about);
	}

	public void Quit(){
		Application.Quit();
	}

}
