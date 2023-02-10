using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class changeScene : MonoBehaviour
{

    Timer timer;
    
    public void ChangeScene(string sceneName)
    {
        int score = PlayerPrefs.GetInt("score");
        
        // Stocker la variable avant de changer de scènex
        // Charger la nouvelle scène
        SceneManager.LoadScene(sceneName);
    }
    public void QuitGame()
    {
        // Quitter le jeu
        Application.Quit();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        
            SceneManager.LoadScene("HighScore");
        
    }
    
}
