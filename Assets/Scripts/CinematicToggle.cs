using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicToggle : MonoBehaviour
{
    public CharacterController playerControl;
    //public GameObject player;
    public Camera cinematicCam;
    public Camera playerCam;

    public void ToggleCinemaMode()
    {
        cinematicCam.enabled = !cinematicCam.enabled;
        playerCam.enabled = !playerCam.enabled;
        playerControl.enabled = !playerControl.enabled;

        //if (checkMark == false)
        //{
        //    checkMark = true;
        //    player.SetActive(true);
        //}
        //
        //else if (checkMark == true)
        //{
        //    checkMark = false;
        //    player.SetActive(false);
        //}
    }
}
