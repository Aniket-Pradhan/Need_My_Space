using UnityEngine;
using System.Collections;
using System.IO;

public class BushSpawner : MonoBehaviour {

	public Transform[] BushSpawnPoints;
	public GameObject Bush;

	void OnTriggerEnter(Collider hit)
	{
		Debug.Log("LOFL");
		Vector3 pos = new Vector3();
		pos = BushSpawnPoints[0].transform.parent.position;
		float width = BushSpawnPoints[0].transform.parent.GetComponent<Collider>().bounds.size.z;
		pos.z = pos.z + width;
		pos.y = 0f;
		Instantiate(Bush, pos, BushSpawnPoints[0].transform.parent.rotation);
	}

}
