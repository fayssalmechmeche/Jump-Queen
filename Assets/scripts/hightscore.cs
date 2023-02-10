using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hightscore : MonoBehaviour
{
    public TextMeshProUGUI text ;
    // Start is called before the first frame update
    void Start()
    {
        int score =  PlayerPrefs.GetInt("score");
        text.text = score.ToString();
    }

}
