using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetlevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    
}
