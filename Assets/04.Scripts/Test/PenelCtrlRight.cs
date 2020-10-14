using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenelCtrlRight : MonoBehaviour
{
    // 스크립트
    public PenelChange2 penelChange;

    // 움직일놈
    public RectTransform rectTr;

    // 속도
    public float speed = 5;

    // 포즈
    Vector2 ednPos = Vector2.zero ;
    Vector2 startPos = new Vector2 (1500,0) ;

    // 비교해줄 자료형
    bool isOnButtonClicked = false;

    // Update is called once per frame
    void Update()
    {
        if(isOnButtonClicked == true)
        {
            rectTr.anchoredPosition = Vector2.Lerp(rectTr.anchoredPosition, ednPos, Time.deltaTime * speed);
        }
        else
        {
            rectTr.anchoredPosition = Vector2.Lerp(rectTr.anchoredPosition, startPos, Time.deltaTime * speed);
        }
    }

    public void IsOnClicked()
    {
        if(isOnButtonClicked == false)
        {
            isOnButtonClicked = true;
            penelChange.panelIndex = +1;
        }
        else
        {
            isOnButtonClicked = false; 
        }
    }


}
