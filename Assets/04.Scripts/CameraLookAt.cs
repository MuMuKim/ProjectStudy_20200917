using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public TouchMgr touchMgr;

    Camera arCamera;

    private void Start()
    {
       arCamera = GameObject.Find("First Person Camera").GetComponent<Camera>();
    }
    void Update()
    {
        //if ( touchMgr.cnt == 1)

        transform.LookAt(transform.position + arCamera.transform.rotation * Vector3.back,
                     arCamera.transform.rotation * Vector3.up);
        //Vector3 normalVec = arCamera.transform.position - transform.position;
        //normalVec.Normalize();

        //transform.rotation = Quaternion.LookRotation(normalVec);
        //transform.LookAt(arCamera.transform.position);
    }
}
