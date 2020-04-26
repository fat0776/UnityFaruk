using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour { 
    public ScoreManager MyScoreManager;
     public AudioSource audioSource;
    public string levelName;
    void OnTriggerEnter2D(Collider2D other)
    {
        //if (MyScoreManager.score ==2)
        //{
            if (other.CompareTag("Player"))
            { 
                StartCoroutine(ExampleCoroutine()); //Untere Funktion wird aufgerufen -> wartet 0.5s damit Sound abgespielt wird und danach neue Szene laden
                audioSource.Play();
            }
        //}
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(levelName);
    }

}
