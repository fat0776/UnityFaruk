using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTeleporterSprite : MonoBehaviour
{
    public ScoreManager MscoreManager;
    public Animator transport;
    // Start is called before the first frame update
    void Start()
    {
       transport = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MscoreManager.score == 2)
        {
            transport.Play("AnimTeleporter");
        }


    }
}
