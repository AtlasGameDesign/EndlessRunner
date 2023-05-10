using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //vergeet je namespace niet toe te voegen



public class teleportlevels : MonoBehaviour

{

    //Belangrijk: Zorg dat je functie public is

    void Update()


    {
        if (Input.GetKey(KeyCode.Return)) //vooruit W
        {
            Debug.Log("Nextsxene");
            SceneManager.LoadScene(1);
        }
    }
}