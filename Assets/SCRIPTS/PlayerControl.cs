using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 25f;
    public float horizontalInput, verticalInput;

    private void Update()
    {
        //detectar el movimiento del input
        horizontalInput = Input.GetAxis("Horitzontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * 20 * Time.deltaTime * verticalInput);

    }
}
