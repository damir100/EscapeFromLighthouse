using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource window;
    public AudioSource end;

    private void Awake()
    {
        Cursor.visible = true;
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.U))
        {
            window.Play();
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            end.Play();
        }
    }
}
