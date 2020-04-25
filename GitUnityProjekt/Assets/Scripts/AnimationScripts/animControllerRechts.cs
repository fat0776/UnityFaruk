using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animControllerRechts : MonoBehaviour
{
    public Animator animrechts;
    // Start is called before the first frame update
    void Start()
    {
        animrechts = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxis("Horizontal") > 0))
        {
            animrechts.Play("NachRechtsGehen2");
        }
        if ((Input.GetAxis("Horizontal") == 0))
        {
            animrechts.Play("Stehen");
        }
    }
}
