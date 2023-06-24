using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    // int life = 10;
    
    
    private void OnCollisionEnter(Collision other) 
    {
    
    // hits++;
    // life--;
    // Debug.Log("ამდენჯერ დაეჯახე უკვე რაღაცას : "+hits+"ჯერ"); 
    // Debug.Log("დარჩენილი სიცოცხლე : "+life); 
    if(other.gameObject.tag == "Hit")
    {
        Debug.Log("arafer");
    }
    else
    {
        hits++;
        Debug.Log("ამდენჯერ დაეჯახე უკვე რაღაცას : "+hits+"ჯერ"); 
    }
    //  if (life <= 0)
    // {
    //  Debug.Log("დეგელია სიცოცხლე ჭოოო");
    // }  

    
    }
}
