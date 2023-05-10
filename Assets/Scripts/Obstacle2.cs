using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle2 : MonoBehaviour
{


    void Start()
    {

    }

    void Update()
    {
        Destroy(gameObject, 35); //5 is how many seconds you want before the object deletes itself
            }
 }