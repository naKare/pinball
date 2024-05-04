using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choque : MonoBehaviour
{
    public AudioClip sonidoChoque;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = sonidoChoque;
    }

    void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
    }
}
