using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenDoor : MonoBehaviour
{
    [SerializeField]
    GameObject Door;

    bool Change = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Green")
        {
            StartCoroutine("DoorOpen");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Green")
        {
            StartCoroutine("DoorClose");
        }
    }

    private void DoorOpen()
    {
        Door.gameObject.transform.position += new Vector3(0, 5f, 0);

    }

    private void DoorClose()
    {
        Door.gameObject.transform.position += new Vector3(0, -5f, 0);
 
    }
}
