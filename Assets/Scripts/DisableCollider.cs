using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCollider : MonoBehaviour
{
    public Collider colliderToEnable;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            colliderToEnable.enabled = !colliderToEnable.enabled;
        }
    }
}
