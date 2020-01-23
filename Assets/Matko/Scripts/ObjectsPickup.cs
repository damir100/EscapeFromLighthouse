using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsPickup : MonoBehaviour
{
    public GameObject pajser;
    public GameObject handPajser;

    public GameObject glass;
    public GameObject handGlass;

    public bool triggerPajser = false;
    public bool triggerGlass = false;

    public bool GlassIsPickedUp = false;

    private void Start()
    {
        handPajser.SetActive(false);
        handGlass.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pajser")
        {
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
            }
        }

        if(other.tag == "Glass")
        {
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
            }
        }
    }
}
