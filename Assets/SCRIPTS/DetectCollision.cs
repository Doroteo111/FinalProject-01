using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private int result;
    private void OnTriggerEnter(Collider other)  //The mashroom will disapear when the ball touch it
    {
        if (other.gameObject.name.Contains("Mushroom")) //every prefab with the same name or contain the name will obey the if
        {
            Destroy(other.gameObject);
            result++;
            Debug.Log($"You have collected {result} Mushroom"); //show the amunt of mashroom you have during the gameplay
            Victory();
        }
       
    }

   
    
    private void Victory() //when you ontain 30 mashroom,a message will shown and the screen stops
    {
        if (result == 30)
        {
            Debug.Log("YOU WIN!!");
            Time.timeScale = 0;
        }
    }
    
}