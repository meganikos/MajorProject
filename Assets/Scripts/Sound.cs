using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource ErrorSound;

    void Start()
    {
        ErrorSound = GetComponent<AudioSource>();
    }

}
