using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{


    
        public int gemsValues = 1;

        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Players"))
            {
                ScoreManager.instance.ChangeScore(gemsValues);
                Destroy(gameObject);
            }
        }
    

}
