using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardBoard : MonoBehaviour
{
    public GameObject key;
    public GameObject handKey;
    public GameObject OpendBox;
    public GameObject glass;

    public Text textObjectives;

    public Text text;
    public Text keyText;

    public ObjectsPickup pickupScript;

    public AudioSource cut;

    public bool idk = false;
    public bool keyHold = false;

    private void Start()
    {
        OpendBox.SetActive(false);
        keyText.text = "";
        handKey.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(pickupScript.GlassIsPickedUp)
        {
            text.text = "Press 'E' to open the box with glass.";
            if(Input.GetKeyDown(KeyCode.E))
            {
                OpendBox.SetActive(true);
                gameObject.SetActive(false);
                text.text = "";
                key.SetActive(false);
                handKey.SetActive(true);
                glass.SetActive(false);
                keyHold = true;
                cut.Play();

                textObjectives.text = "Exit the lighthouse.";
            }

        } else
        {
            text.text = "You need something sharp to open the box";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        text.text = "";
        keyText.text = "";
    }
}
