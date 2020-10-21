using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenelCtrl : MonoBehaviour
{
    // 스크립트
    public PenelChange2 penelChange;

    // UI는 Transform이 아닌 RectTransform;
    public RectTransform rectTr;

    // 스피드값도 변수로 만들어주는 걸 추천
    public float speed = 5;
    
    // 스타트 포즈와 엔드포즈 ( z축이 필요 없기 때문에 벡터2를 사용)
    public Vector2 startPos = new Vector2(0, -3500f);
    public Vector2 endpos = Vector2.zero;

    // 버튼이 눌렸는지 안 눌렸는지 구분
    public bool isButtonClicked = false;

    void Update()
    {
        if(isButtonClicked == true)
        {
            // RectTransform은 anchoredPosition을 사용해야함 / 러프를 쓰고싶은 자료형을 쓰고 러프 / 움직이고 싶은놈, 도착지점, 속력)
            rectTr.anchoredPosition = Vector2.Lerp(rectTr.anchoredPosition, endpos, Time.deltaTime * speed);
        }
        else
        {
            rectTr.anchoredPosition = Vector2.Lerp(rectTr.anchoredPosition, startPos, Time.deltaTime * speed);
        }
    }

    public void OnButtonClicked()
    {
        if(isButtonClicked == false)
        {
            Debug.Log("트루");
            isButtonClicked = true;
            penelChange.panelIndex = +1;
        }
        else
        {
            Debug.Log("펄스");
            isButtonClicked = false;
        }
    }
}
