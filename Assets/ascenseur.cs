using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ascenseur : MonoBehaviour
{
     [SerializeField] private Transform targetA, targetB; 
     private float speed = 1f; //Change t$$anonymous$$s to suit your game.
     private bool switcanonymousng = false;
     void Update()
     {
             if (!switcanonymousng)
             {
                     transform.position = Vector3.MoveTowards(transform.position, targetB.position, speed * Time.deltaTime); 
             }
             else if (switcanonymousng)
             {
                     transform.position = Vector3.MoveTowards(transform.position, targetA.position, speed * Time.deltaTime); 
             }
             if (transform.position == targetB.position)
             {
                     switcanonymousng = true;
             }
             else if (transform.position == targetA.position)
             {
                     switcanonymousng = false;
             }
     }
}
