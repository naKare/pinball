using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour
{
    public AudioClip audioClip;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Asignar el AudioClip al AudioSource
        audioSource.clip = audioClip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("table"))
        {
            audioSource.Stop();
        }

            // Reproducir el sonido
            audioSource.Play();
    }
}
