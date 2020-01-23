using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoor : MonoBehaviour
{
    public GameObject mainDoorClosed;

    public CardBoard keySrcipt;
    public AudioSource door;

    private void Start()
    {
        mainDoorClosed.SetActive(true);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(keySrcipt.keyHold)
        {
            mainDoorClosed.SetActive(false);
            door.Play();
        }
    }
}
