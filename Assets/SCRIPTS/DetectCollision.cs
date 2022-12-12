using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private int points = 1; //couting coins collected
    private int result;
    private void OnTriggerEnter(Collider other)  //the sphere collision wit the coin, and it destroyed
    {
        if (other.gameObject.name.Contains("coin"))
        {
            Destroy(other.gameObject);
        }
       
    }

    private void Start()
    {
        Counter(points);
    }
    private void Counter(int x)
    {
        result = x++;
        if (true)
        {
            Debug.Log($"You have collected {result} coins");
        }
    }
    private void Victory()
    {
        if (result == 30)
        {
            Debug.Log("YOU WIN!!");
        }
    }
}