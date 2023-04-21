using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnim : MonoBehaviour
{
    public GameObject thingToAnimate;
    public Animator animToPlay;
    public string triggerName;

    public void PlayAnim()
    {
        thingToAnimate.GetComponent<Animator>().SetTrigger(triggerName);
    }

   //public void PlayNextAnim()
   //{
   //    // call something on a TARGET object.
   //    onEndAnim.Raise(this, null);
   //}
}
