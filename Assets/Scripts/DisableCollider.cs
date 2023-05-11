using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCollider : MonoBehaviour
{
    public Collider colliderToEnable;

    public void ToggleCollider(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            colliderToEnable.enabled = !colliderToEnable.enabled;
        }
    }
}
