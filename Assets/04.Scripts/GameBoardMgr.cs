﻿using System;
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
    public BottonMgr bottonMgr;
    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward * rayDistance);
        RaycastHit hit;

        // 레이를 쏴 그리드를 검출
        if (Physics.Raycast(ray, out hit, rayDistance, gridLayer))
        {
            // 생성된 큐브가 있을 때
            if (hit.collider.CompareTag("CUBE"))
            {
                guideCube.SetActive(false); // 가이드 큐브를 꺼놓는다.
                if(bottonMgr.obj == hit.collider.gameObject)
                {
                    hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;
                }
                else
                {
                    bottonMgr.obj.GetComponent<MeshRenderer>().material.color = Color.red;
                }

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
            }
            //Debug.Log($"GameBoardMgr ::: hit.collider.gameObject.name // {hit.collider.gameObject.name}");
        }
        else
        {
            guideCube.SetActive(false);
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
