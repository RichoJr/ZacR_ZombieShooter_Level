using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallChecking : MonoBehaviour
{
    public float wallDistance = 4f;
    public float sphereSize = 5f;
    Renderer rend;

    void Update()
    {
        LayerMask mask = LayerMask.GetMask("Wall");
        CheckWall(mask);
    }

    public void CheckWall(LayerMask mask)
    {
        RaycastHit check;
        GameObject currentObject;
        GameObject postObject;
        postObject = null;

        //Old way to hide walls. It only works if the raycast hits the front of the object.
        //if (Physics.Raycast(transform.position, Vector3.forward, out check, wallDistance, mask))
        //{
        //    Debug.Log("Shot Hit");
        //    currentObject = check.transform.gameObject;
        //    Debug.Log(currentObject);
        //
        //    StartCoroutine(WallBreakTime(currentObject, postObject));
        //
        //    postObject = null;
        //}

        if(Physics.SphereCast(transform.position, sphereSize,transform.forward, out check, wallDistance, mask))
        {
            Debug.Log("Shot Hit");
            currentObject = check.transform.gameObject;
            Debug.Log(currentObject);
            rend = currentObject.GetComponent<Renderer>();

            StartCoroutine(WallBreakTime(currentObject, postObject, rend));
            postObject = null;
        }
        if (!Physics.SphereCast(transform.position, sphereSize, transform.forward, out check, wallDistance, mask))
        {
            rend.enabled = true;
        }


    }

    IEnumerator WallBreakTime(GameObject currentObject, GameObject postObject, Renderer rend)
    {
        Debug.Log("Off");
        //currentObject.SetActive(false);
        rend.enabled = false;
        postObject = currentObject;
        yield return new WaitForSeconds(0.5f);
        //postObject.SetActive(true);

    }
}
