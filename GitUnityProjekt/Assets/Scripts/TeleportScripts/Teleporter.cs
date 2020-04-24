using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour { 
    public ScoreManager MyScoreManager;
    
    public string levelName;
    void OnTriggerEnter2D(Collider2D other)

    {
        if (MyScoreManager.score ==2)
        {
            if (other.CompareTag("Player"))
            { 
                SceneManager.LoadScene(levelName);
            }
        }

    }

}
