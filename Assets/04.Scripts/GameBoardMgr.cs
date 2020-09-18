using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 목표 : 그리드를 향해 레이를 쏴 가이드 큐브를 보이게 한다.
// 그리드를 향해 레이를 쏴
// 가이드 큐브를 보이게 한다.

public class GameBoardMgr : MonoBehaviour
{
    //ray
    public GameObject cam;
    public float rayDistance = 10.0f;
    public LayerMask gridLayer;

    //grid 위에 생성한 큐브
    public GameObject guideCube;

    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward * rayDistance);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, rayDistance, gridLayer))
        {
            guideCube.SetActive(true);
            guideCube.transform.position = hit.transform.Find("CubePos").position;
            guideCube.transform.rotation = hit.transform.parent.rotation;

        }

        //Ray ray = new Ray(cam.transform.position, cam.transform.forward * rayDistance);
        //RaycastHit hit;

        ////ray를 쏴서 8번 layer를 검출
        //if(Physics.Raycast(ray,out hit, rayDistance, 1 << 8))
        //{
        //    //guide cube 활성화
        //    //1. 그리드의 자식 오브젝트 중 CubePos라는 오브젝트를 찾는다
        //    GameObject grid = hit.collider.gameObject;
        //    Transform cubePos = grid.transform.Find("CubePos").transform;

        //    //2. CubePos의 위치에 guide cube를 활성화한다
        //    guideCube.SetActive(true);
        //    guideCube.transform.position = cubePos.position;
        //    guideCube.transform.rotation = hit.transform.parent.rotation;
        //}
    }
}
