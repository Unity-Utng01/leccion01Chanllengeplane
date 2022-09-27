using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
Descripcion:En este script el avion se enclinara con las teclas de arriba y abajo
Autor: Eva Quintero Carrillo
Date:17/09/2022
**/

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate este avanza forwoard//punot 1 forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);//agrege el * Time.deltaTime

        // tilt the plane up/down based on up/down arrow keys
    //   transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
      transform.Rotate(Vector3.right, Time.deltaTime * rotationSpeed * verticalInput);//punto 3 listo

     
    }
}
