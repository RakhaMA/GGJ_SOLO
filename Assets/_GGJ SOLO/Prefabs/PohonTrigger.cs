using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PohonTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(GetComponentInParent<PohonController>().mleyotPrank)
            {
                GetComponentInParent<Animator>().SetTrigger("Mleyot_Prank");
            }
            else
                GetComponentInParent<Animator>().SetTrigger("Mleyot");

            Destroy(this.gameObject);
        }
    }
}
