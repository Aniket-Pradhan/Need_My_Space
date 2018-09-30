using UnityEngine;
using System.Collections;
using System.Linq;

public class StuffSpawner : MonoBehaviour
{
    //points where stuff will spawn :)
    public Transform[] StuffSpawnPoints;
    //meat gameobjects
    public GameObject[] scoreThings;
    //obstacle gameobjects
    public GameObject[] Obstacles;

    public GameObject[] bonus;

    public bool RandomX = false;
    public float minX = -2f, maxX = 2f;

    // Use this for initialization
    void Start()
    {
        int[] indecis = new int[StuffSpawnPoints.Length];
        for (int i = 0; i < indecis.Length; i++)
        {
            indecis[i] = -1;
        }
        
        //first, let's decide whether we'll place an obstacle
        //beware, Random.Range is exclusive for integers but inclusive for floats
        //http://answers.unity3d.com/questions/585266/question-about-randomrange.html
        
        //Obstacles
        bool placeObstacle = Random.Range(0, 2) == 0; //50% chances
        int obstacleIndex = -1;
        if (placeObstacle)
        {
            //select a random spawn point, apart from the first one
            //since we do not want an obstacle there
            obstacleIndex = Random.Range(1, StuffSpawnPoints.Length);
            Vector3 v = new Vector3(StuffSpawnPoints[obstacleIndex].position.x, 1f, StuffSpawnPoints[obstacleIndex].position.z);
            CreateObject(v, Obstacles[Random.Range(0, Obstacles.Length)]);
        }

        //Score shit
        for (int i = 0; i < StuffSpawnPoints.Length; i++)
        {
            //don't instantiate if there's an obstacle
            if (i == obstacleIndex) continue;
            if (Random.Range(0, 3) == 0) //33% chances to create candy
            {
                indecis[i] = i;
                Vector3 v = new Vector3(StuffSpawnPoints[i].position.x, 1f, StuffSpawnPoints[i].position.z);
                CreateObject(v, scoreThings[Random.Range(0, scoreThings.Length)]);
            }
        }
        
        
        //Bonus shit
        for (int i = 0; i < StuffSpawnPoints.Length; i++)
        {
            //don't instantiate if there's an obstacle
            if (i == obstacleIndex) continue;
            if (Random.Range(0, 20) == 0) //1/20% chances to create candy
            {
                if (!indecis.Contains(i))
                {
                    Vector3 v = new Vector3(StuffSpawnPoints[i].position.x, 1f, StuffSpawnPoints[i].position.z);
                    CreateObject(v, bonus[Random.Range(0, bonus.Length)]);   
                }
            }
        }


    }

    void CreateObject(Vector3 position, GameObject prefab)
    {
        if (RandomX) //true on the wide path, false on the rotated ones
            position += new Vector3(Random.Range(minX, maxX), 0, 0);

        Instantiate(prefab, position, Quaternion.identity);
    }


}
