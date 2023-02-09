using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI text ;
    public static ScoreManager instance;
    int score ;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = " X " + score.ToString();
        PlayerPrefs.SetInt("score", score);
    }
    
    public int GetScore()
    {
        PlayerPrefs.GetInt("score");
        text.text = score.ToString();
        return score;
    }
}
