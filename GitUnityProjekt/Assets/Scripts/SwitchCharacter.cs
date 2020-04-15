using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacter : MonoBehaviour //mache extra stehen charakter -> idle
{
    public GameObject vorn, hinten, rechts, links; //wie mache ich von vorne stehen, von hinten stehen?
    int whichAvatarIsOn = 1;

    void Start()
    {
        vorn.gameObject.SetActive(true);
        hinten.gameObject.SetActive(false);
        rechts.gameObject.SetActive(false);
        links.gameObject.SetActive(false);


    }
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0) //nach rechts laufen
        {
            whichAvatarIsOn = 1;
            SwitchAvatar();
        }
        if (Input.GetAxis("Horizontal") < 0) //nach links laufen
        {
            whichAvatarIsOn = 2;
            SwitchAvatar();
        }
        if (Input.GetAxis("Vertical") > 0) //nach oben laufen
        {
            whichAvatarIsOn = 3;
            SwitchAvatar();
        }
        if (Input.GetAxis("Vertical") < 0) //nach unten laufen
        {
            whichAvatarIsOn = 4;
            SwitchAvatar();
        }
        //if ((Input.GetAxis("Horizontal") == 0) && (Input.GetAxis("Vertikal") == 0)) //weder horizontal noch vertikal laufen -> stehen
        //{
        //    whichAvatarIsOn = 5;
        //    SwitchAvatar();
        //}


    }
    public void SwitchAvatar()
    {

        switch (whichAvatarIsOn)
        {
            case 1: //nach rechts laufen

                vorn.gameObject.SetActive(false);
                hinten.gameObject.SetActive(false);
                rechts.gameObject.SetActive(true);
                links.gameObject.SetActive(false);
                break;

            case 2: //nach links laufen
                vorn.gameObject.SetActive(false);
                hinten.gameObject.SetActive(false);
                rechts.gameObject.SetActive(false);
                links.gameObject.SetActive(true);
                break;

            case 3: //nach oben laufen
                vorn.gameObject.SetActive(false);
                hinten.gameObject.SetActive(true);
                rechts.gameObject.SetActive(false);
                links.gameObject.SetActive(false);
                break;

            case 4: //nach unten laufen
                vorn.gameObject.SetActive(true);
                hinten.gameObject.SetActive(false);
                rechts.gameObject.SetActive(false);
                links.gameObject.SetActive(false);
                break;
        }
    }
}
