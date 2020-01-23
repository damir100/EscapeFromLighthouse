using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHover : MonoBehaviour
{
    public AudioSource hover;
    public AudioClip buttonHoverSound;

    public void HoverSound()
    {
        hover.PlayOneShot(buttonHoverSound);
    }
}
