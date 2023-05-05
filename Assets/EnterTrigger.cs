using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTrigger : MonoBehaviour
{
    [Header("Events")]
    public GameEvent onTouch;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            onTouch.Raise(this, null);
            //Destroy(gameObject);
        }
    }
}
