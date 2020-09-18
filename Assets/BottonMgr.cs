using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// 큐브 생성 , 삭제 , 리셋 , 게임보드 삭제 버튼 생성 및 실행

public class BottonMgr : MonoBehaviour
{
    public GameObject cube;
    public GameBoardMgr gameBoardMgr;

    // 큐브생성
    public void CreateCube()
    {
        Debug.Log("BottonMgr ::: 큐브 생성");

        Transform gcp = gameBoardMgr.guideCube.transform;

        Instantiate(cube, gcp.position, gcp.rotation);
    }
}
