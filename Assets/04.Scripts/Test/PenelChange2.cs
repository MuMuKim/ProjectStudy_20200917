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
}
