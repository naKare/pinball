using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReiniciarJuego : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnGUI()
    {


        if (GUI.Button(new Rect(5, 5, 100, 20), "Comenzar"))
        {
            SceneManager.LoadScene("Assets/Scenes/scene1.unity", LoadSceneMode.Single);
        }

    }

}




