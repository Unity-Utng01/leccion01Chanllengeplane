using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
Descripcion:En este script la camara seguira al avion 
Autor: Eva Quintero Carrillo
Date:17/09/2022
**/

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(30,0,10);//punto 5 camara sigue al avión

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset ;
    }
}
