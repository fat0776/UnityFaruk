using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControllerHinten : MonoBehaviour
{
    public Animator animhinten;
    // Start is called before the first frame update
    void Start()
    {
        animhinten = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxis("Vertical") > 0))
        {
            animhinten.Play("GoUp2");
        }
        if ((Input.GetAxis("Vertical") == 0))
        {
            animhinten.Play("Stayhinten"); 
        }
    }
}
