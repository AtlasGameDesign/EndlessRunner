using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public int score;
    public int lives = 3;


    Vector3 startPosition;
    Quaternion startRotation;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        {
            int scoreAmount = (int)(1f);
            score += scoreAmount;
        }
        //Respawn
        if (Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
        }
    }



    //je hoeft geen triggers aan te duiden
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        if(collision.collider.CompareTag("Obstacle"))
        {

            lives--;

            if(lives <= 0)
            {
                //Time.timeScale = 0;
                SceneManager.LoadScene(2);
            }

            Destroy(collision.gameObject);
        }
        if (collision.collider.CompareTag("Obstaclestay"))
        {

            lives--;

            if (lives <= 0)
            {
                Time.timeScale = 0;
            }


        }
    }

}
