using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private int result;
    private void OnTriggerEnter(Collider other)  //the sphere collision wit the mushroom, and it destroyed
    {
        if (other.gameObject.name.Contains("Mushroom"))
        {
            Destroy(other.gameObject);
            result++;
            Debug.Log($"You have collected {result} Mushroom");
            Victory();
        }
       
    }

   
    
    private void Victory()
    {
        if (result == 30)
        {
            Debug.Log("YOU WIN!!");
            Time.timeScale = 0;
        }
    }
    
}