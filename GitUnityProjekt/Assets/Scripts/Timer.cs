using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    float EndTime = 20f;




    void Update()
    {
        EndTime -= 1 * Time.deltaTime;
        if (EndTime <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}







