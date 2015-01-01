using UnityEngine;
using System.Collections;

public class CycleGrounds : MonoBehaviour {

	public Transform ground, player;

	private float prevPos;
	private Transform ground0, ground1;
	private bool current; //fasle = 0, true = 1
	private Quaternion q;

	// Use this for initialization
	void Start () {
		prevPos = 0;
		current = false;
		q = ground.rotation;
		ground0 = Instantiate(ground, Vector3.zero, q) as Transform;
		ground1 = Instantiate(ground, new Vector3(100,100,100), q) as Transform; //very far!
	}
	
	// Update is called once per frame
	void Update () {

		if(prevPos - player.position.z > 3)
			Recycle();
	}

	private void Recycle() {
		if(current)
		{	
			Vector3 pos = ground1.position;
			pos.z -= 10;
			Object.Destroy(ground0.gameObject);
			ground0 = Instantiate(ground, pos, q) as Transform;
			prevPos = pos.z;
		}
		else
		{
			Vector3 pos = ground0.position;
			pos.z -= 10;
			Object.Destroy(ground1.gameObject);
			ground1 = Instantiate(ground, pos, q) as Transform;
			prevPos = pos.z;
		}
		current = !current;
		
	}
}
