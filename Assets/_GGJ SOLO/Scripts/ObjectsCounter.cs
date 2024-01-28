using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsCounter : MonoBehaviour
{
    public int objectsCount = 0;
    // check if any object is staying on the trigger area, and count it
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Objects"))
        {
            objectsCount++;
            GameManager.instance.objectCounterText.text = ("Objects : ") + objectsCount.ToString("0");
        }
    }

    // check if any object is leaving the trigger area, and count it
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Objects"))
        {
            objectsCount--;
            GameManager.instance.objectCounterText.text = ("Objects : ") + objectsCount.ToString("0");
        }
    }
}
