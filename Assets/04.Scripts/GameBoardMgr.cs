using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;


// 목표 : 그리드를 향해 레이를 쏴 가이드 큐브를 보이게 한다.
// 그리드를 향해 레이를 쏴
// 가이드 큐브를 보이게 한다.

public class GameBoardMgr : MonoBehaviour
{
    //ray
    public GameObject cam;
    public float rayDistance = 10.0f;
    public LayerMask gridLayer;

    //grid 위에 생성한 가이드 큐브
    public GameObject guideCube;

    // 스크립트
    public ButtonMgr buttonMgr;

    // 박스컬러
    GameObject currColor; //default 색 =빨강
    GameObject thisColor; //cyan 레이에 맞았을때 색

    //private GameObject currCube;

    private GameObject prevCube;
    private GameObject currCube;

    // 조준점
    public GameObject pointer;


    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward * rayDistance);
        RaycastHit hit;
        Debug.DrawRay(cam.transform.position, cam.transform.forward * rayDistance, Color.yellow);

        // 레이를 쏴 그리드를 검출
        if (Physics.Raycast(ray, out hit, rayDistance, gridLayer))
        {
            // 포인터의 액티브를 true로 바꾸고, 조준점을 카메라 가운데로 맞춘다
            pointer.SetActive(true);
            pointer.transform.position = hit.point + (hit.normal * 0.005f);
            pointer.transform.rotation = Quaternion.LookRotation(hit.normal);
            // 생성된 큐브가 있을 때
            if (hit.collider.CompareTag("CUBE"))
            {
                guideCube.SetActive(false); // 가이드 큐브를 꺼놓는다.

                currColor = thisColor;
                thisColor = hit.collider.gameObject;
                hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;

                if (currColor != null && currColor != thisColor)
                {
                    currColor.GetComponent<MeshRenderer>().material.color = Color.red;
                }


                #region 창현 & 재현쌤 코드
                //if (currCube != null && currCube != hit.collider.gameObject)
                //{
                //    currCube.GetComponent<MeshRenderer>().material.color = Color.red;
                //}

                //currCube = hit.collider.gameObject;
                //currCube.GetComponent<MeshRenderer>().material.color = Color.cyan;


                //currCube = hit.collider.gameObject;

                //if (currCube != prevCube && prevCube != null)
                //{
                //    prevCube.GetComponent<MeshRenderer>().material.color = Color.red;
                //}

                //currCube.GetComponent<MeshRenderer>().material.color = Color.cyan;
                //prevCube = currCube;
                #endregion
 
                // Debug.Log("1층");
                // Debug.Log($"히트노말{hit.normal}");

                // Hit된 노말백터가 백터3 up(y)과 같을 때 (X) 이유 : 월드가 아님
                // Hit된 노말백터와 Hit된 오브젝트의 로컬up방향과 같을 때 (O)
                if (hit.normal == hit.transform.up.normalized)
                {
                    // Debug.Log("2층");
                    guideCube.SetActive(true);

                    guideCube.transform.position = hit.transform.GetChild(0).gameObject.transform.position;
                }    
            }
            // 생성된 큐브가 없을 때
            else
            {
                guideCube.SetActive(true);
                guideCube.transform.position = hit.transform.Find("CubePos").position;
                guideCube.transform.rotation = hit.transform.parent.rotation;
                

                if (thisColor != null)
                {
                    // thisColor의 색을 빨간색으로 바꾼다.
                    thisColor.transform.GetComponent<MeshRenderer>().material.color = Color.red;
                }
            }
            //Debug.Log($"GameBoardMgr ::: hit.collider.gameObject.name // {hit.collider.gameObject.name}");
        }
        else
        {
            guideCube.SetActive(false);
            if (thisColor != null)
            {
                // thisColor의 색을 빨간색으로 바꾼다.
                thisColor.transform.GetComponent<MeshRenderer>().material.color = Color.red;
            }
        }

        #region 창현 코드
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
        #endregion
    }
}
