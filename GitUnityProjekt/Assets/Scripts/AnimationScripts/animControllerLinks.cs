using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animControllerLinks : MonoBehaviour
{
    public Animator animlinks;
    // Start is called before the first frame update
    void Start()
    {
        animlinks = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxis("Horizontal") < 0))
        {
            animlinks.Play("GoLeft2");
        }
        if ((Input.GetAxis("Horizontal") == 0))
        {
            animlinks.Play("Stay");
        }
    }
}
