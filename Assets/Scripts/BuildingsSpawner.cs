using UnityEngine;
using System.Collections;
using System.IO;

public class BuildingsSpawner : MonoBehaviour {

//    public float positionY = 0.81f;
	public Transform[] BuildingSpawnPoints;
	public GameObject Building1;

	private int _count;

	void Start()
	{
		_count = 0;
	}
//    public GameObject DangerousBorder;

	void OnTriggerEnter(Collider hit)
	{
		Debug.Log("LOFL");
		Vector3 pos = new Vector3();
		pos = BuildingSpawnPoints[0].transform.parent.position;
//		RectTransform rt = (RectTransform)BuildingSpawnPoints[0].transform.parent.transform;
//		float width = rt.rect.width;
		float width = BuildingSpawnPoints[0].transform.parent.GetComponent<Collider>().bounds.size.z;
		pos.z = pos.z + width - 5;
		pos.y = 0f;
		Instantiate(Building1, pos, BuildingSpawnPoints[0].transform.parent.rotation);
//		throw new FileNotFoundException(BuildingSpawnPoints[0].position.ToString() + "  " +BuildingSpawnPoints[0].transform.parent.position.ToString());

		_count += 1;
	}

}
