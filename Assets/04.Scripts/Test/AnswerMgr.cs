using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerMgr : MonoBehaviour
{
    // 스크립트
    [SerializeField] private AnswerList anList;

    // 정답 패널
    [SerializeField] private GameObject answerTeT; 
    [SerializeField] private GameObject wrongTeT; 

    // 정답 입력
    [SerializeField] private InputField answerNum;

    // 정답버튼
    [SerializeField] private GameObject nextBnt;

    // 구분
    int cnt = 0;
    bool Isbool = false;

    public void Update()
    {
        
    }
    public void Answer()
    {

        if(anList.answerArray[0] == int.Parse(answerNum.text))
        {
            answerTeT.SetActive(true);
            wrongTeT.SetActive(false);

            nextBnt.SetActive(true);
            cnt = 1;

            print("정답");
        }
        else
        {
            wrongTeT.SetActive(true);
            answerTeT.SetActive(false);
            print("오답");
        }

        
    }

    public void NextLav2()
    {
        Isbool = true;
        if (cnt == 1 && Isbool)
        {
            print("들어옴");
            Isbool = false;
            nextBnt.SetActive(false);
            answerTeT.SetActive(false);
            wrongTeT.SetActive(false);
            answerNum.text = "";
            if (anList.answerArray[1] == int.Parse(answerNum.text))
            {
                answerTeT.SetActive(true);
                wrongTeT.SetActive(false);

                nextBnt.SetActive(true);
                cnt = 2;
            }
            else
            {
                wrongTeT.SetActive(true);
                answerTeT.SetActive(false);
            }
        }
    }
}
