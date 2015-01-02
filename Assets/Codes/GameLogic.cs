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

	public void ObstacleHit(){
		GameOver();
	}

	private void GameOver(){
		Debug.Log("Game Over!");
		Time.timeScale = 0f;
	}
}
