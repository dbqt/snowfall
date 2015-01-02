using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {

	private int score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//called when player hit something
	public void ObstacleHit(){
		GameOver();
	}

	//gameover logic
	private void GameOver(){
		Debug.Log("Game Over!");
		Time.timeScale = 0f;
	}
}
