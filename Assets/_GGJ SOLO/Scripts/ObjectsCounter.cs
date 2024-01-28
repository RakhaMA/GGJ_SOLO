using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsCounter : MonoBehaviour
{
    // check if any object is staying on the trigger area, and count it
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Objects"))
        {
            GameManager.instance.objectsCount++;
            GameManager.instance.objectCounterText.text = ("Objects : ") + GameManager.instance.objectsCount.ToString("0") + ("/") + GameManager.instance.maxObjectsThisLevel.ToString("0");
        }
    }

    // check if any object is leaving the trigger area, and count it
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Objects"))
        {
            GameManager.instance.objectsCount--;
            GameManager.instance.objectCounterText.text = ("Objects : ") + GameManager.instance.objectsCount.ToString("0") + ("/") + GameManager.instance.maxObjectsThisLevel.ToString("0");
            if (GameManager.instance.objectsCount == 0)
            {
                GameManager.instance.GameOver();
            }
        }
    }

}
