using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {

	public GameObject restartBtn, menuBtn;
	private int score;

	// Use this for initialization
	void Start () {
	Time.timeScale = 1f;
	restartBtn.SetActive(false);
	menuBtn.SetActive(false);
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
		Time.timeScale = 0.1f;
		restartBtn.SetActive(true);
		menuBtn.SetActive(true);		
	}
}
