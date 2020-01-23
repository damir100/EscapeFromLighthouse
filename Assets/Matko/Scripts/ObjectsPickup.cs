﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectsPickup : MonoBehaviour
{
    public GameObject pajser;
    public GameObject handPajser;

    public GameObject glass;
    public GameObject handGlass;

    public AudioSource dropItem;
    public AudioSource dropGlass;
    public AudioSource background;

    public bool triggerPajser = false;
    public bool triggerGlass = false;

    public bool PajserIsPickedUp = false;
    public bool GlassIsPickedUp = false;

    private void Start()
    {
        Cursor.visible = false;
        handPajser.SetActive(false);
        handGlass.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pajser")
        {
            PajserIsPickedUp = true;
            GlassIsPickedUp = false;

            triggerPajser = true;
            if(triggerPajser)
            {
                //Pajser
                pajser.SetActive(false);
                handPajser.SetActive(true);

                //Staklo
                handGlass.SetActive(false);
                glass.SetActive(true);

                if (triggerGlass)
                {
                    dropGlass.Play();
                }

            }
        }

        if(other.tag == "Glass")
        {
            PajserIsPickedUp = false;
            GlassIsPickedUp = true;

            triggerGlass = true;
            if (triggerGlass)
            {
                //Staklo
                glass.SetActive(false);
                handGlass.SetActive(true);

                //Pajser
                handPajser.SetActive(false);
                pajser.SetActive(true);

                if(triggerPajser)
                {
                    dropItem.Play();
                }
            }
        }
    }
}
