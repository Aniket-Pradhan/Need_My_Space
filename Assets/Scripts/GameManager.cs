using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject circle;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(this);
        }
    }
    

    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }

    protected GameManager()
    {
        GameState = GameState.Start;
        CanSwipe = false;
    }

    public GameState GameState { get; set; }

    public bool CanSwipe { get; set; }
    
    public void Die()
    {
//            UIManager.Instance.SetStatus(Constants.StatusDeadTapToStart);
//            this.GameState = GameState.Dead; 
        if (getCircle() - 0.4f > 0.4f)
        {
            decCircle(0.4f);
        }
        else
        {
            decCircle(0.4f);
            UIManager.Instance.SetStatus(Constants.StatusDeadTapToStart);
            this.GameState = GameState.Dead;   
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void bonus1()
    {
        incCircle(1f);
    }

    public void bonus2()
    {
        FindObjectOfType<CharacterSidewaysMovement>().incSpeed(1.3f);
    }
    
    public float getCircle()
    {
        return circle.transform.localScale.x;
    }

    public void decCircle(float value)
    {
        float val = circle.transform.localScale.x;
        circle.transform.localScale = new Vector3(val-value,val-value,val-value);
        Debug.Log(1/value);
        UIManager.Instance.IncreaseAnScore(1/value);
    }

    public void incCircle(float value)
    {
        float val = circle.transform.localScale.x;
        circle.transform.localScale = new Vector3(val+value,val+value,val+value);
        Debug.Log(1/value);
        UIManager.Instance.IncreaseAnScore(value * 20);
    }

}



