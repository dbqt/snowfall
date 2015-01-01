using UnityEngine;
using System.Collections;

public class PlayerProperties : MonoBehaviour {

	public float rollSpeed = 1, speedCap = 5;
	
	// Update is called once per frame
	void Update () {
		//simulate gravity
		rigidbody.AddForce(Vector3.back * rollSpeed);

		//limit horizontal
		Vector3 pos = this.gameObject.transform.position;
		if(this.gameObject.transform.position.x < -9)
			pos.x = -9;
		if(this.gameObject.transform.position.x > 9)
			pos.x = 9;
		this.gameObject.transform.position = pos;

		Vector3 vel = this.gameObject.rigidbody.velocity;
		if(this.gameObject.rigidbody.velocity.z > speedCap)
			vel.z = speedCap;
		this.gameObject.rigidbody.velocity = vel;

	}
}
