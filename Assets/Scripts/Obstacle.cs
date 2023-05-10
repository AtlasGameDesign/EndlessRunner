using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speedMod = 20;
    public float despawnDistance = -25;

    PlayerMovement player;

    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
    }

    void Update()
    {
        transform.position -= Vector3.forward  * speedMod * Time.deltaTime;

        if(transform.position.z < despawnDistance)
        {
            Destroy(gameObject);
        }
    }
}
