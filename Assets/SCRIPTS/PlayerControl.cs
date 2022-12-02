using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed = 20f;
    public float turnSpeed = 10f;

    private float horizontalInput, verticalInput; //movment
    
    private void Update()
    {
       horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        
        transform.Translate(Vector3.forward * speed * Time.deltaTime *verticalInput);

        transform.Translate(Vector3.right* turnSpeed * Time.deltaTime * horizontalInput);




        //hacer moneda o x (scrip del proyectil con el collaider)
        //hacer que cuando cosilione con la bola, sume un punto
    }
}
