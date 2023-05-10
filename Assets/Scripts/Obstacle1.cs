using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle1 : MonoBehaviour
{


    void Start()
    {

    }

    void Update()
    {
        Destroy(gameObject, 23); //5 is how many seconds you want before the object deletes itself
            }
 }