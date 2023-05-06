using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterBuilding : MonoBehaviour
{
    public GameObject player;
    public GameObject decoy;
    public Transform building;

    [Header("Events")]
    public GameEvent onLocationReached;

    public void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.CompareTag("Player"))
        {
            onLocationReached.Raise(this, null);
        }
        
    }
    public void OnTriggerExit()
    {
        Debug.Log("Entered Building");
        player.transform.position = building.position;
    }
}
