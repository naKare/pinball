using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuego : MonoBehaviour
{
    public ParticleSystem ParticleSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto con el que choc� es una pelota
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Activa el sistema de part�culas
            ParticleSystem.Play();
            StartCoroutine(DetenerParticulas());
        }
    }

    private IEnumerator DetenerParticulas()
    {
        // Espera 3 segundos
        yield return new WaitForSeconds(3f);

        // Detiene el sistema de part�culas
        ParticleSystem.Stop();
    }
}
