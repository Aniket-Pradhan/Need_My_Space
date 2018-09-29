using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

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
        if (getCircle() - 0.2f > 0.2f)
        {
            decCircle(0.2f);
        }
        else
        {
            decCircle(0.2f);
            UIManager.Instance.SetStatus(Constants.StatusDeadTapToStart);
            this.GameState = GameState.Dead;             
        }
    }
    
    public float getCircle()
    {
        return circle.transform.localScale.x;
    }

    public void decCircle(float value)
    {
        float val = circle.transform.localScale.x;
        circle.transform.localScale = new Vector3(val-value,val-value,val-value);	
    }

}



