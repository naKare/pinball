using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private GameObject Ball;

    private int contadorClicks = 0;
    public int clicksParaCambiarEscena = 3;

    private void Start()
    {
        Ball = GameObject.FindWithTag("Ball");
        int contadorGuardado = PlayerPrefs.GetInt("ContadorClicks", 0);
        if (contadorGuardado >= clicksParaCambiarEscena)
        {
            CambiarEscena();
        }
    }

    void OnGUI()
    {
        if (Ball != null && Ball.transform.position.z <= -6.9f)
        {
            if (GUI.Button(new Rect(5, 5, 100, 20), "Restart (" + PlayerPrefs.GetInt("ContadorClicks", 0) + ")"))
            {
                int contadorClicks = PlayerPrefs.GetInt("ContadorClicks", 0) + 1;
                PlayerPrefs.SetInt("ContadorClicks", contadorClicks);

                if (contadorClicks >= clicksParaCambiarEscena)
                {
                    CambiarEscena();
                }
                else
                {
                    RecargarEscena();
                }
            }

        }


    }

    void CambiarEscena()
    {
        PlayerPrefs.SetInt("ContadorClicks", 0);
        SceneManager.LoadScene("Assets/Scenes/scene2.unity", LoadSceneMode.Single);
    }

    void RecargarEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}



