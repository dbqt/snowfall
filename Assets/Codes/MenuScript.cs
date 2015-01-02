using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
	public string game, about, menu;

	public void PlayGame(){
		Application.LoadLevel(game);
	}

	public void About(){
		Application.LoadLevel(about);
	}

	public void Menu(){
		Application.LoadLevel(menu);
	}

	public void Quit(){
		Application.Quit();
	}

}
