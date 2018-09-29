using UnityEngine;
using System.Collections;

public class PathSpawnCollider : MonoBehaviour {

//    public float positionY = 0.81f;
    public Transform[] PathSpawnPoints;
    public GameObject Path;
//    public GameObject DangerousBorder;

    void OnTriggerEnter(Collider hit)
    {
        //player has hit the collider
//        if (hit.gameObject.tag == Constants.PlayerTag)
        {
            //find whether the next path will be straight, left or right
//            int randomSpawnPoint = Random.Range(0, PathSpawnPoints.Length);
//            int randomSpaw    nPoint = 0;
//            for (int i = 0; i < PathSpawnPoints.Length; i++)
//            {
                //instantiate the path, on the set rotation
//                if (i == randomSpawnPoint)
                    Instantiate(Path, PathSpawnPoints[0].position, PathSpawnPoints[0].rotation);
//            Instantiate(Path, PathSpawnPoints[0].position, PathSpawnPoints[0].rotation);
//            Instantiate(Path, new Vector3(0,0,PathSpawnPoints[0].position.z) + PathSpawnPoints[0].position, PathSpawnPoints[0].rotation);

//            Instantiate(Path, Path.transform.position, Path.transform.rotation);

//                else
//                {
//                    //instantiate the border, but rotate it 90 degrees first
//                    Vector3 rotation = PathSpawnPoints[i].rotation.eulerAngles;
//                    rotation.y += 90;
//                    Vector3 position = PathSpawnPoints[i].position;
//                    position.y += positionY;
//                    Instantiate(DangerousBorder, position, Quaternion.Euler(rotation));
//                }
//            }
            
        }
    }

}
