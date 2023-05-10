using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameralift : MonoBehaviour
{
    public Transform target;
    public float speed;
    public float step;
    // Start is called before the first frame update
    void Start()
    {
      //  transform.position = target.position;
    }

    // Update is called once per frame
    void Update()
    {
        //step = speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)

    {
      

        if (other.CompareTag("lift"))
       
        { Debug.Log("halloooo");
            transform.position = target.position;
            step = speed * Time.deltaTime;
            Camera.main.transform.position = Vector3.MoveTowards
                (transform.position, target.position, step); } //(x,y,z)
    }


    
}
