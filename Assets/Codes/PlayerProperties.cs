using UnityEngine;
using System.Collections;

public class PlayerProperties : MonoBehaviour {

	public float rollSpeed = 1, speedCap = 5, growSpeed = 1, growCap = 4;

	private float last = 0;
	
	// Update is called once per frame
	void FixedUpdate () {
		//simulate gravity
		rigidbody.AddForce(Vector3.back * rollSpeed);

		//limit horizontal
		Vector3 pos = this.gameObject.transform.position;
		if(this.gameObject.transform.position.x < -9)
			pos.x = -9;
		if(this.gameObject.transform.position.x > 9)
			pos.x = 9;
		this.gameObject.transform.position = pos;

		//limit velocity
		Vector3 vel = this.gameObject.rigidbody.velocity;
		if(this.gameObject.rigidbody.velocity.z > speedCap)
			vel.z = speedCap;
		this.gameObject.rigidbody.velocity = vel;

		//grow size
		if(last - this.gameObject.transform.position.z > 1 && this.gameObject.transform.localScale.x < growCap)
		{
			this.gameObject.transform.localScale = this.gameObject.transform.localScale * growSpeed * 1.01f;
			last = this.gameObject.transform.position.z;
		}

	}

	//tell GameManager that player hit something
	void OnCollisionEnter(Collision other) {

		if(other.transform.tag != "ground")
			this.gameObject.SendMessageUpwards("ObstacleHit");
	}
}
