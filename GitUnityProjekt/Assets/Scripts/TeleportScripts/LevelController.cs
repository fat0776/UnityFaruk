using System;
using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {

    static int sec = 1;
    public string levelName;
    void OnTriggerEnter2D(Collider2D other)
    {
        if ((DateTime.Now.Ticks - start) < sec*90000000) return;
        UnityEngine.Debug.Log(start);

        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(levelName);
            start = DateTime.Now.Ticks;
        }
    }

    public static long start = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}
