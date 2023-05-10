using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //vergeet je namespace niet toe te voegen



public class teleportbegin : MonoBehaviour

{

    //Belangrijk: Zorg dat je functie public is

    void Update()


    {
        if (Input.GetMouseButtonDown(1)) //vooruit W
        {
            Debug.Log("Nextsxene");
            SceneManager.LoadScene(0);
        }
    }
}