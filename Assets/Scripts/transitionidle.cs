using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transitionidle : MonoBehaviour
{
    public GameObject Statics;
    void OnTriggerEnter(Collider other)

    {

        if (other.CompareTag("pan"))
            Statics.GetComponent<Animation>().Play("static");
    }
}
