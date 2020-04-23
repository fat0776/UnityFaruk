using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControllerCharacter : MonoBehaviour
{

    public static Dictionary<int, Vector2>
        savedPositions =
        new Dictionary<int, Vector2>();

    public bool ready = false;

    // Start is called before the first frame update
    void Update()
    {
        if (!ready)
        {
            UnityEngine.Debug.Log("Start");
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            UnityEngine.Debug.Log("Start on: " + sceneIndex);

            if (savedPositions.ContainsKey(sceneIndex))
            {
                UnityEngine.Debug.Log("Got it");
                Vector2 position = savedPositions[sceneIndex];
                UnityEngine.Debug.Log("Load: " + sceneIndex + " - " + transform.position);
                transform.position = position;
            }
            ready = true;
        }
    }

    void OnDestroy()
    {
        UnityEngine.Debug.Log("onDestroy");

        int sceneIndex =
            SceneManager
                .GetActiveScene()
                .buildIndex;
        UnityEngine.Debug.Log(sceneIndex);

        UnityEngine.Debug.Log("Save: " + sceneIndex + " - " + transform.position);
        savedPositions[sceneIndex] = transform.position;
    }

}
