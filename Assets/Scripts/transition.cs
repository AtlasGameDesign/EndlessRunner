using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transition : MonoBehaviour
{
    public GameObject FadeScreen;
    void OnTriggerEnter(Collider other)

    {

        if (other.CompareTag("trans"))
            FadeScreen.GetComponent<Animation>().Play("fadeanim");
    }
}
