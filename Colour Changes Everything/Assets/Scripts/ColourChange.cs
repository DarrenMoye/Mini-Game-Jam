using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ColourChange : MonoBehaviour
{
    [SerializeField]
    private float JumperPower;

    [SerializeField]
    private Contoller _contoller;

    bool entered = true;


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "DoorTrigger")
        {
            entered = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "DoorTrigger")
        {
            entered = true;
        }
    }

    bool HasJumped = false;

    private void OnCollisionEnter(Collision other)
    {
        Rigidbody Player = GetComponent<Rigidbody>();
        if (HasJumped == false && other.gameObject.tag == "Red" )
        {
            Player.isKinematic = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        HasJumped = false;
    }

    public void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha1) && entered == true)
        {
            gameObject.tag = "Black";
            gameObject.GetComponent<Renderer>().material.color = Color.black;

            _contoller.JumpHeight = 10.0f;
            _contoller.PlayerSpeed = 2.0f;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && entered == true)
        {
            gameObject.tag = "Green";
            gameObject.GetComponent<Renderer>().material.color = Color.green;
           
            _contoller.JumpHeight = 12.5f;
            _contoller.PlayerSpeed = 2.0f;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && entered == true)
        {
            gameObject.tag = "Blue";
            gameObject.GetComponent<Renderer>().material.color = Color.blue;

            _contoller.JumpHeight = 1.5f;
            _contoller.PlayerSpeed = 2.0f;
        }
    }
}
