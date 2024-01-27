using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GedungController : MonoBehaviour
{
    public GameObject[] gedungCollider;
    public GameObject[] gedungMesh;
    public void OnMLeyotAnimationEndEvent()
    {
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
