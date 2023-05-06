using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [Header("Events")]
    public GameEvent uniqueInteractionName;
    // Start is called before the first frame update
    public void TriggerEvent()
    {
        uniqueInteractionName.Raise(this, null);
    }
}
