using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyscene : MonoBehaviour
{

    public GameObject FadeScreen;

    public void OnTriggerEnter ()
    {
        FadeScreen.GetComponent<Animation>().Play("fadeanim");
    }
}
