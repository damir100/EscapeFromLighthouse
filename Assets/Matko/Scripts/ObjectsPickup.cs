using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsPickup : MonoBehaviour
{
    public GameObject pajser;
    public GameObject pajser2;

    public bool trigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pajser")
        {
            trigger = true;
        }
    }
}
