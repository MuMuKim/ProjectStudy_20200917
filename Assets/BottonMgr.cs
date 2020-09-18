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
        GameObject gc = gameBoardMgr.guideCube;
        Transform gcp = gameBoardMgr.guideCube.transform;
        // 생성된 큐브 자리에는 다른 큐브가 생기면 안된다
        if (gc.activeSelf)
        {           
            Debug.Log("BottonMgr ::: 큐브 생성");
            Instantiate(cube, gcp.position, gcp.rotation);
        }
    }
        
}
