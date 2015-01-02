using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameLogic : MonoBehaviour {

	public GameObject restartBtn, menuBtn, player;
	public Text t;
	private float score;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1f;
		restartBtn.SetActive(false);
		menuBtn.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		score = -player.transform.position.z;
		t.text = ""+(int)score;
	}

	//called when player hit something
	public void ObstacleHit(){
		GameOver();
	}

	//gameover logic
	private void GameOver(){
		Debug.Log("Game Over!");
		Time.timeScale = 0f;
		restartBtn.SetActive(true);
		menuBtn.SetActive(true);		
	}
}
