using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    float currentTime = 0f;
    float EndTime = 20f;

    void Start()
    {
        currentTime = EndTime;    
    }


    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        if (currentTime <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}







