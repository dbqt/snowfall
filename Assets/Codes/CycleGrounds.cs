using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CycleGrounds : MonoBehaviour {

	public Transform ground, player, obstacle;
	public int nbObstaclesPerGround = 3;

	private float prevPos;
	private bool current; //fasle = 0, true = 1
	private Transform ground0, ground1;
	private Quaternion q;
	private Queue<Transform> objectQueue;

	// Use this for initialization
	void Start () {
		prevPos = 0;
		current = false;
		q = ground.rotation;
		ground0 = Instantiate(ground, Vector3.zero, q) as Transform;
		ground1 = Instantiate(ground, new Vector3(100,99.9f,100), q) as Transform; //very far!

		objectQueue = new Queue<Transform>(nbObstaclesPerGround*2);
		//create and enqueue for the first time obstacles
		for(int i = 0; i < nbObstaclesPerGround*2 ; i++)
			objectQueue.Enqueue(Instantiate(obstacle, new Vector3(100,101+i,100), Quaternion.identity) as Transform);
	}
	
	// Update is called once per frame
	void Update () {
		if(prevPos - player.position.z > 3)
			Recycle();
	}

	//Recycle() will destroy the far away plane and create a new one for the player to go on
	private void Recycle() {
		//if on ground1, recycle ground0, and vice-versa
		if(current)
		{	
			Vector3 pos = ground1.position;
			pos.z -= 10;
			Object.Destroy(ground0.gameObject);
			ground0 = Instantiate(ground, pos, q) as Transform;
			prevPos = pos.z;
			CycleObstacles(pos);
		}
		else
		{
			Vector3 pos = ground0.position;
			pos.z -= 10;
			Object.Destroy(ground1.gameObject);
			ground1 = Instantiate(ground, pos, q) as Transform;
			prevPos = pos.z;
			CycleObstacles(pos);
		}
		current = !current;
		
	}

	//Places new obstacle around the startPoint
	private void CycleObstacles(Vector3 startPoint)
	{
		for(int i = 0; i < nbObstaclesPerGround ; i++)
		{
			Vector3 obsPos = new Vector3 (Random.Range(-9, 9), 1, Random.Range(-8, 0));
			obsPos = obsPos + startPoint;
			Transform o = objectQueue.Dequeue();
			o.localPosition = obsPos;
			o.gameObject.rigidbody.velocity = Vector3.zero;
			o.gameObject.rigidbody.angularVelocity = Vector3.zero;

			objectQueue.Enqueue(o);
		}
	}
}
