using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
    
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

    //singleton implementation
    private static UIManager instance;
    public static UIManager Instance
    {
        get
        {
            if (instance == null)
                instance = new UIManager();
            
            return instance;
        }
    }

    protected UIManager()
    {
    }

    private float score = 0;


    public void ResetScore()
    {
        score = 0;
        UpdateScoreText();
    }
    
    public void SetScore(float value)
    {
        score = value;
        UpdateScoreText();
    }

    public void IncreaseScore(float value)
    {
        score += value;
        UpdateScoreText();
    }
    
    private void UpdateScoreText()
    {
//        Debug.Log(ScoreText);
        ScoreText.text = score.ToString();
//        ScoreText.text = score.ToString();
    }

    public void UpdateAnxiety(float value)
    {
        AnxLevel.text = value.ToString();
    }

    public void SetStatus(string text)
    {
        StatusText.text = text;
    }

    public TextMeshProUGUI ScoreText, StatusText,AnxLevel;
//    public TextMeshProUGUI


}
