using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTeleporterSprite : MonoBehaviour
{
    public ScoreManager MscoreManager;
    //public Animator transport;
    public GameObject aktiv, inaktiv;
    
    // Start is called before the first frame update
    void Start()
    {
       //transport = GetComponent<Animator>();
        aktiv.gameObject.SetActive(false);
        inaktiv.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if ((MscoreManager.screwsFound >= MscoreManager.screwsInLevel) && 
            (ScoreManager.Instance.score >= MscoreManager.minScore))
        {
            aktiv.gameObject.SetActive(true);
            inaktiv.gameObject.SetActive(false);
        }


    }
}
