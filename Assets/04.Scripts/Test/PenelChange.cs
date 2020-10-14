using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class PenelChange : MonoBehaviour
{
    [Header("GameStart")]
    public GameObject scene1;
    [Header("GamePlay")]
    public GameObject scene2;
    [Header("AloneMode")]
    public GameObject scene3;
    public GameObject scene3_1;
    public GameObject scene3_2;
    public GameObject scene3_3;

    GameObject currPenel;
    GameObject nextPenel;

    public List<GameObject> penelList = new List<GameObject>();

    private void Start()
    {
        penelList.Add(scene1);
        penelList.Add(scene2);
        penelList.Add(scene3);
        penelList.Add(scene3_1);
        penelList.Add(scene3_2);
        penelList.Add(scene3_3);

        //penelList = new List<GameObject>(6) { scene1, scene2, scene3, scene3_1, scene3_2, scene3_3 };

        currPenel = penelList[0];
        nextPenel = penelList[1];

        penelList[0].SetActive(true);
    }

    // 현재 패널과 다음 패널을 알고
    // 현재패널일경우 다음 인덱스로 넣어준다
    // 현재패널과 다음패널이 다를경우
    public void ChangePenel()
    {
        penelList[0].SetActive(false);
        penelList[1].SetActive(true);
    }
    public void ChangePenel1()
    {
        penelList[1].SetActive(false);
        penelList[2].SetActive(true);
    }
    public void ChangePenel2()
    {
        penelList[2].SetActive(false);
        penelList[3].SetActive(true);
    }
    public void ChangePenel3()
    {
        penelList[2].SetActive(false);
        penelList[4].SetActive(true);
    }
    public void ChangePenel3_1()
    {
        penelList[2].SetActive(false);
        penelList[5].SetActive(true);
    }
    public void ChangePenel3_2()
    {
        penelList[2].SetActive(false);
        penelList[6].SetActive(true);
    }
    public void ChangePenelBackAlone()
    {
        
    }
    
}
