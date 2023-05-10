using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transitionsky : MonoBehaviour
{
    public GameObject Flying;
    void OnTriggerEnter(Collider other)

    {

        if (other.CompareTag("lesbean"))
            Flying.GetComponent<Animation>().Play("fly");
    }
}
