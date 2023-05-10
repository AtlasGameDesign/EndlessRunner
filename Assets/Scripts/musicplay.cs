using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicplay : MonoBehaviour

{
    public AudioSource audioSource;
    void Start()
    {
        audioSource.Play();
    }
}