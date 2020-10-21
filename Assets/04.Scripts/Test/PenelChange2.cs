using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenelChange2 : MonoBehaviour
{
    public GameObject[] sceneArrey;

    GameObject currPenel;
    GameObject nextPenel;

    public int panelIndex = 0;

    public GameObject scene3;
    public GameObject scene3_1;
    public GameObject scene3_2;
    public GameObject scene3_3;

    public GameObject profile;

    // 구분변수
    bool profileBool = false;

    // 스크립트
    public PenelCtrl penelUD;
    public PenelCtrlRight penelRight1;
    public PenelCtrlRight penelRight2;
    public PenelCtrlRight penelRight3;

    private void Start()
    {
        //currPenel = sceneArrey[0];
        //nextPenel = sceneArrey[1];
        //currPenel.SetActive(true);

        currPenel = sceneArrey[panelIndex];
        currPenel.SetActive(true);
    }

    //public void ChangePenel()
    //{
    //    print("ChangePenel()");

    //    if(currPenel != nextPenel)
    //    {
    //        currPenel.SetActive(false);
    //        nextPenel.SetActive(true);

    //        currPenel = nextPenel;
    //        nextPenel = sceneArrey[+1];
    //        print("다음" + nextPenel);
    //    }
    //}

    public void BackToTheScene()
    {
        currPenel.SetActive(false);
        panelIndex -= 1;
        Debug.Log("패널인덱스" + panelIndex);
        currPenel = sceneArrey[panelIndex];
        currPenel.SetActive(true);
    }
    public void ChangePanel()
    {
        print("ChangePanel()");

        currPenel.SetActive(false);
        panelIndex += 1;
        currPenel = sceneArrey[panelIndex];
        currPenel.SetActive(true);
    }
    public void AloneMode1()
    {
        print("ChangePanel()");
        scene3.SetActive(false);
        scene3_1.SetActive(true);
    }
    public void AloneMode2()
    {
        print("ChangePanel()");
        scene3.SetActive(false);
        scene3_2.SetActive(true);
    }
    public void AloneMode3()
    {
        print("ChangePanel()");
        scene3.SetActive(false);
        scene3_3.SetActive(true);
    }
    public void profileIn()
    {
        if (profileBool == false)
        {
            profile.SetActive(true);
        }
        else
        {
            profile.SetActive(false);
        }
    }
    public void profileExit()
    {
        if (profileBool == true)
        {
            profileBool = false;
        }
        else
        {
            profileBool = true;
        }
    }

    public void profileButton()
    {
        Debug.Log($"PenelChange2 ::: profile 팝업창 {!profile.activeSelf}");
        profile.SetActive(!profile.activeSelf);
    }

    public void profileBack()
    {
        profile.SetActive(false);
        profileBool = false;
    }
    public void ChangeHome()
    {
        // 패널 1번은 키고 
        sceneArrey[1].SetActive(true);
        // 러프로 움직이는 놈들은 다시 초기화
        penelUD.isButtonClicked = false;
        penelRight1.isOnButtonClicked = false;
        penelRight2.isOnButtonClicked = false;
        penelRight3.isOnButtonClicked = false;

    }

    public void GotoMainaMenu()
    {
        //main menu panel 켜기
        panelIndex = 1;
        sceneArrey[panelIndex].SetActive(true);

        //나머지는 다 끄기
        for (int i = 0; i < sceneArrey.Length; i++)
        {
            //main menu일 때는 바로 다음으로 넘어간다
            if (i == 1)
            {
                continue;
            }

            sceneArrey[i].SetActive(false);

            //if (i == 1)
            //{
            //    sceneArrey[i].SetActive(true);
            //}
        }
        panelIndex++;
        penelUD.isButtonClicked = false;
        penelRight1.isOnButtonClicked = false;
    }
}
