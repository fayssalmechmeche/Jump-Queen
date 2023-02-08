using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemsManager : MonoBehaviour
{
   
   public int coinValue = 1;
   private void OnTriggerEnter2D (Collider2D collision)
   {
       if (collision.gameObject.tag == "Players")
       {
           ScoreManager.instance.ChangeScore(coinValue);
       }
   }
}
