using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private GameObject Ball;

    private void Start()
    {
        Ball = GameObject.FindWithTag("Ball");
    }

    void OnGUI()
    {
        
        if (Ball != null && Ball.transform.position.z <= -6.9f)
        {
            if (GUI.Button(new Rect(5, 5, 100, 20), "Restart"))
            {
                SceneManager.LoadScene("Assets/Scenes/scene1.unity", LoadSceneMode.Single);
            }
        }
    }
}
