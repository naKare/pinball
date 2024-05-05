using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuego : MonoBehaviour
{
    public ParticleSystem ParticleSystem;
<<<<<<< HEAD

    private ParticleSystem particl;
    // Start is called before the first frame update
    void Start()
    {
        particl = ParticleSystem;
=======
    // Start is called before the first frame update
    void Start()
    {
        
>>>>>>> e0e3759f7a284e9823f9b58cdb38987f936f5e68
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
<<<<<<< HEAD
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (particl != null)
            {
                particl.Play();
                StartCoroutine(DetenerParticulas());
            }
=======
        // Verifica si el objeto con el que chocó es una pelota
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Activa el sistema de partículas
            ParticleSystem.Play();
            StartCoroutine(DetenerParticulas());
>>>>>>> e0e3759f7a284e9823f9b58cdb38987f936f5e68
        }
    }

    private IEnumerator DetenerParticulas()
    {
<<<<<<< HEAD
        yield return new WaitForSeconds(3f);

        if (particl != null)
        {
            particl.Stop();
        }
=======
        // Espera 3 segundos
        yield return new WaitForSeconds(3f);

        // Detiene el sistema de partículas
        ParticleSystem.Stop();
>>>>>>> e0e3759f7a284e9823f9b58cdb38987f936f5e68
    }
}
