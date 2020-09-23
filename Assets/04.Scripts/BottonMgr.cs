﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// 큐브 생성 , 삭제 , 리셋 , 게임보드 삭제 버튼 생성 및 실행

public class BottonMgr : MonoBehaviour
{
    public GameObject cam;
    public GameObject cube;

    // 생성된큐브
    public GameObject obj;

    public GameBoardMgr gameBoardMgr;
    public TouchMgr touchMgr;

    List<GameObject> cubeList =new List<GameObject>();

    // 큐브생성
    public void CreateCube()
    {
        // 게임보드 매니저 스크립트 
        GameObject gc = gameBoardMgr.guideCube;
        Transform gcp = gameBoardMgr.guideCube.transform;


        // 생성된 큐브 자리에는 다른 큐브가 생기면 안된다
        if (gc.activeSelf)
        {
            Debug.Log("BottonMgr ::: 큐브 생성");

            //GameObject obj = Instantiate(cube);
            //obj.transform.position = gcp.position;
            //obj.transform.rotation = gcp.rotation;

            // 생성된 큐브를 obj변수에 담아 큐브 리스트에 넣는다.
            obj = Instantiate(cube, gcp.position, gcp.rotation);
            obj.transform.parent = touchMgr.gameBoard.transform;
            cubeList.Add(obj);
        }
    }

    // 큐브 삭제
    public void ReMoveCube()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward* 10f);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit , 10, 1 << 8))
        {
            if (hit.collider.CompareTag("CUBE"))
            {
                GameObject obj = hit.collider.gameObject;
                Destroy(obj);
                Debug.Log("큐브삭제");
            }
        }
    }

    // 큐브 리셋
    public void ResetCube()
    {
        // 만들어진 큐브들을 리스트에 넣어주고, 리셋버튼을 누르면 삭제
        // 큐브가 만들어진 순간 리스트에 들어간다
        // 들어갈 리스트가 필요하다

        for (int i = 0; i < cubeList.Count; i++)
        {
            Destroy(cubeList[i].gameObject);
        }
        cubeList.Clear();
    }

    // 게임보드 리셋
    public void GbReset()
    {
        Destroy(touchMgr.gameBoard);
        touchMgr.cnt = 0;
    }
}
