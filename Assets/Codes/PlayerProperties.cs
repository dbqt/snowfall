using UnityEngine;
using System.Collections;

public class PlayerProperties : MonoBehaviour {

	public float rollSpeed = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.AddForce(Vector3.back * rollSpeed);
	}
}
