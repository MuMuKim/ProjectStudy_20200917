using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// 큐브 생성 , 삭제 , 리셋 , 게임보드 삭제 버튼 생성 및 실행

public class BottonMgr : MonoBehaviour
{
    public GameObject cam;
    public GameObject cube;
    public GameBoardMgr gameBoardMgr;

    private void Start()
    {
        

    }
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
            Instantiate(cube, gcp.position, gcp.rotation);
        }
    }
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
}
