using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GedungTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponentInParent<Animator>().SetTrigger("Mleyot");
            Destroy(this.gameObject);
        }
    }
}
