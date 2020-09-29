using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollider : MonoBehaviour
{

    public GameBoardMgr gameBoardMgr;

    private void OnTriggerEnter(Collider other)
    {
        gameBoardMgr.guideCube.SetActive(false);
        Debug.Log("트리커체크");
    }
}
