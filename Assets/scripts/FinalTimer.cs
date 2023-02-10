using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalTimer : MonoBehaviour
{
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        float timer =  PlayerPrefs.GetFloat("timer");
        text.text = timer.ToString();
        
    }

}
