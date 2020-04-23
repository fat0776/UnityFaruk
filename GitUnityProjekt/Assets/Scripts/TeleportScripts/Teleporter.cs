using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour { 

    
    public string levelName;
    void OnTriggerEnter2D(Collider2D other)

    {
        if (other.CompareTag("Player"))
        { 
            SceneManager.LoadScene(levelName);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
