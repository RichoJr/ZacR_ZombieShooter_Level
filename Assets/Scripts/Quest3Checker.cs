using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest3Checker : MonoBehaviour
{
    public int counter = 0;

    [Header("Events")]
    public GameEvent onAllCollected;

    
    public void OnEventCompleted()
    {
        counter++;
        if(counter == 6)
        {
            onAllCollected.Raise(this, null);
        }
    }
   
}
