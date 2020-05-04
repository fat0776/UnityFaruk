using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animControllerVorn : MonoBehaviour
{
    public Animator animvorn;
    // Start is called before the first frame update
    void Start()
    {
        animvorn = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxis("Vertical") < 0))
        {
            animvorn.Play("GoDown2");
        }
        if ((Input.GetAxis("Vertical") == 0))
        {
            animvorn.Play("StayVorn");
        }
    }
}
