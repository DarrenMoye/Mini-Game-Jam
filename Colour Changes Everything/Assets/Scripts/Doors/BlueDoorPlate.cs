using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDoorPlate : MonoBehaviour
{
    [SerializeField]
    GameObject Door;

    bool Change = false;
    bool pressed = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Blue")
        {
            pressed = true;
            StartCoroutine("DoorOpen");
        }
    }
    private void DoorOpen()
    {
        if (pressed == true)
        {
            Door.gameObject.transform.position += new Vector3(0, 5f, 0);
        }
    }
}
