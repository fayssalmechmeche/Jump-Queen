using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    static Time timer;
    public float timeDuration = 0f;
    public float timeRemaining;
    // Start is called before the first frame update
    void Start()
    {
         timeRemaining = timeDuration;

        
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining += Time.deltaTime;
        PlayerPrefs.SetFloat("timer",timeRemaining);
    }

    void OnGUI(){
         GUI.Label(new Rect(10, 10, 100, 20), "Time: " + timeRemaining.ToString("0.0"));
    }

    
}
