using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprintAndCrouch : MonoBehaviour
{
    private PlayerMovement playerMovment;

    public float sprint_Speed = 10f;
    public float move_Speed = 5f;
    public float crouch_Speed = 2f;

    //private Transform look_Root;
    private float stand_Height = 1f;
    private float crouch_Height = 0.5f;

    public bool is_Crouching = false;
    public bool isRunning = false;


    void Awake()
    {
        playerMovment = GetComponent<PlayerMovement>();

        //look_Root = transform.GetChild(0);
    }


    void Update()
    {
        Running();
        Sprint();
        //Crouch();
    }

    void Sprint()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && is_Crouching == false)
        {
            isRunning = true;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift) && is_Crouching == false)
        {
            isRunning = false;
        }
    }

    void Crouch()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            is_Crouching = !is_Crouching;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            is_Crouching = false;
        }

        if (is_Crouching == false)
        {
            transform.localScale = new Vector3(0f, Mathf.Lerp(transform.localScale.y, stand_Height, Time.deltaTime * 4), 0f);
            //look_Root.localPosition = new Vector3(0f, stand_Height, 0f);
            
        }
        else if(is_Crouching == true)
        {
            transform.localScale = new Vector3(0f, Mathf.Lerp(transform.localScale.y, crouch_Height, Time.deltaTime * 4), 0f);
            //look_Root.localPosition = new Vector3(0f, crouch_Height, 0f);
            playerMovment.speed = Mathf.Lerp(playerMovment.speed, crouch_Speed, Time.deltaTime * 5);
            //playerMovment.speed = crouch_Speed;
            isRunning = false;
            
            
        }
    }
    void Running()
    {
        if (isRunning == true)
        {
            playerMovment.speed = Mathf.Lerp(playerMovment.speed, sprint_Speed, Time.deltaTime * 5);
            //playerMovment.speed = sprint_Speed;
        }
        else
        {
            playerMovment.speed = Mathf.Lerp(playerMovment.speed, move_Speed, Time.deltaTime * 5);
            //playerMovment.speed = move_Speed;
        }
    }
}
