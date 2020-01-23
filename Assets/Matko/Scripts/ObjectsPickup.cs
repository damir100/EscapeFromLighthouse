using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsPickup : MonoBehaviour
{
    public GameObject pajser;
    public GameObject handPajser;

    public bool triggerPajser = false;

    private void Start()
    {
        handPajser.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerPajser = true;
        if (triggerPajser)
        {
            pajser.SetActive(false);
            handPajser.SetActive(true);
        }
    }
}
