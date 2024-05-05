using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuego : MonoBehaviour
{
    public ParticleSystem ParticleSystem;

    private ParticleSystem particl;
    // Start is called before the first frame update
    void Start()
    {
        particl = ParticleSystem;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (particl != null)
            {
                particl.Play();
                StartCoroutine(DetenerParticulas());
            }
        }
    }

    private IEnumerator DetenerParticulas()
    {
        yield return new WaitForSeconds(3f);

        if (particl != null)
        {
            particl.Stop();
        }
    }
}
