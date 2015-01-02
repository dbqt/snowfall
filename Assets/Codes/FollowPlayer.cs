using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public Transform player;
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.position = new Vector3(player.position.x,this.gameObject.transform.position.y,player.position.z);
	}
}
