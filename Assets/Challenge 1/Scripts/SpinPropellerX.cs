using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**Descripcion:En este script el avión avanza hacia delante.
Autor: Eva Quintero Carrillo
Date:17/09/2022
**/

public class SpinPropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    private float propeller = 1000;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     transform.Rotate(Vector3.forward, propeller * Time.deltaTime);
   
    }
}
