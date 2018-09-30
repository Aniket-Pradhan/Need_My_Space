using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class Candy : MonoBehaviour
{
    //candy found in https://www.assetstore.unity3d.com/en/#!/content/12512
    public bool bonus;
    public int ScorePoints = 100;
    public float rotateSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed);
    }

    void OnTriggerEnter(Collider col)
    {
        if(!bonus)
        {
            FindObjectOfType<AudioManager>().Play("PageTurn");
            UIManager.Instance.IncreaseScore(ScorePoints);
            Destroy(this.gameObject);
        }
        else
        {
            //No score increase.
            //Activate special ability for `x` seconds
            //Phone -> Shield, for upto 15s. Basically, it increases the radius of the sphere by 10 pts, for 15 seconds. OR something like, it gets a clean chit for another contact
            //HeadPhones -> Increases the personal space by 20. 
            
            Destroy(this.gameObject);
        }
    }
}
