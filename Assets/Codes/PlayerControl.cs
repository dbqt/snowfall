using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	public float moveSpeed = 10;
	
	// Update is called once per frame
	void Update () {

		//keyboard input
		float direction = Input.GetAxis("Horizontal");
		//mouse or touch input will overwrite keyboard input
		if (Input.GetMouseButton(0))
		{
			direction = Mathf.Sign( Input.mousePosition.x - (Screen.width/2) );
		}
		//apply force to move
		rigidbody.AddForce(Vector3.right * direction * moveSpeed);
	}
}
