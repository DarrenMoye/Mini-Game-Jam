using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackDoor : MonoBehaviour
{
    [SerializeField]
    GameObject Door;

    bool Change = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Black")
        {
            StartCoroutine("DoorOpen");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Black")
        {
            StartCoroutine("DoorClose");
        }
    }

    private IEnumerator DoorOpen()
    {
        Door.gameObject.transform.position += new Vector3(0, 5f, 0);

        yield return new WaitForSeconds(2.0f);
    }

    private IEnumerator DoorClose()
    {
        Door.gameObject.transform.position += new Vector3(0, -5f, 0);

        yield return new WaitForSeconds(2.0f);
    }
}

