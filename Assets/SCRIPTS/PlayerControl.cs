using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    private float speed = 20f;
    private float turnSpeed = 60f; //speed

    private float horizontalInput, verticalInput; //movment

    private void Update()
    {
        //Movment
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        /*transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);*/

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

            
    }

    
}
