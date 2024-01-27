using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GedungController : MonoBehaviour
{
    public bool isPatah;

    [Space(10)] public GameObject[] gedungCollider;
    public GameObject[] gedungMesh;
    public void OnMLeyotAnimationEndEvent()
    {
        if (!isPatah)
            return;

        foreach(GameObject obj in gedungCollider)
        {
            obj.SetActive(true);
        }
        foreach (GameObject obj in gedungMesh)
        {
            obj.SetActive(false);
        }
    }
}
