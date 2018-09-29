using UnityEngine;
using System.Collections;

public class PathSpawnCollider : MonoBehaviour {

//    public float positionY = 0.81f;
    public Transform[] PathSpawnPoints;
    public GameObject Path;

    void OnTriggerEnter(Collider hit)
    {
        Debug.Log("TEST");
        Instantiate(Path, PathSpawnPoints[0].position, PathSpawnPoints[0].rotation);
    }

}
