using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed = 20f;
    public float turnSpeed = 50f; //speed

    private float horizontalInput, verticalInput; //movment

    /*private int points = 1; //couting coins collected
    private int result;*/

    /*private void Start()
    {
        Counter(points);  
    }*/

    private void Update()
    {
        //Movment
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        /*transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);*/

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

            
    }

    /*private void Counter(int x)
    {
        result = x++;
        if (true)
        {
            Debug.Log($"You have collected {result} coins");
        }
    }*/

    /*private void Victory()
    {
        if (result == 30)
        {
            Debug.Log("YOU WIN!!");
        }
    }*/
}
