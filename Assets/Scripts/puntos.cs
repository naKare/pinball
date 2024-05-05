using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntos : MonoBehaviour
{
    // Start is called before the first frame update
    public int conteoPuntos = 0; 
    public float fuerza = 5f; 

    private Rigidbody rb; 
    public TextMeshProUGUI textoPuntos;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("puntos100"))
        {
            conteoPuntos += 100; 
            ActualizarPuntos();
            Debug.Log("Has sumado 100 puntos. Puntos totales: " + conteoPuntos);
        }

        if (other.CompareTag("puntos50"))
        {
            conteoPuntos += 50; 
            ActualizarPuntos();
            Debug.Log("Has sumado 50 puntos. Puntos totales: " + conteoPuntos);
        }
        if (other.CompareTag("puntos25"))
        {
            conteoPuntos += 25; 
            ActualizarPuntos();
            Debug.Log("Has sumado 25 puntos. Puntos totales: " + conteoPuntos);
        }
        if (other.CompareTag("disparo"))
        {
            Vector3 direccion = other.transform.position + transform.position; 
            rb.AddForce(direccion.normalized * fuerza, ForceMode.Impulse); 
        }


    }

    private void ActualizarPuntos()
    {
        // Actualizar el texto de los puntos
        if (textoPuntos != null)
        {
            textoPuntos.text = "Score: " + conteoPuntos;
        }
    }

    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
