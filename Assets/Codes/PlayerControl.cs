using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	public float moveSpeed = 1;
	
	// Update is called once per frame
	void Update () {
		float direction = Input.GetAxis("Horizontal");
		rigidbody.AddForce(Vector3.right * direction * moveSpeed);
	}
}
