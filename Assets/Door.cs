using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public Text doorText;

    public ObjectsPickup objectScript;

    public GameObject door;
    public GameObject openedDoor;

    public AudioSource doors;

    void Start()
    {
        doorText.text = "";
        openedDoor.SetActive(false);
        door.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(objectScript.PajserIsPickedUp)
        {
            door.SetActive(false);
            openedDoor.SetActive(true);
            doors.Play();

        } else
        {
            doorText.text = "You need something stronger to open the door.";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        doorText.text = "";
    }
}
