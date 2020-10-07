using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenelChange2 : MonoBehaviour
{
    public GameObject[] sceneArrey;

    GameObject currPenel;
    GameObject nextPenel;

    int panelIndex = 0;

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

    public void ChangePanel()
    {
        print("ChangePanel()");

        currPenel.SetActive(false);
        panelIndex += 1;
        currPenel = sceneArrey[panelIndex];
        currPenel.SetActive(true);
    }
}
