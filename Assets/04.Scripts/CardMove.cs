using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMove : MonoBehaviour
{
    public RectTransform endPos;
    public RectTransform startPos;
    private RectTransform rectTr;

    bool Isbool = false;
    RectTransform currPos;
    int touchCount;


    private void Start()
    {
        rectTr = GetComponent<RectTransform>();
    }
    private void Update()
    {
        currPos = Isbool ? endPos : startPos;
        rectTr.anchoredPosition = Vector2.Lerp(rectTr.anchoredPosition, currPos.anchoredPosition,0.1f);
    }
    public void CardMoving()
    {
        if(touchCount == 0)
        {
            Isbool = true;
            touchCount = 1;
        }
        else
        {
            Isbool = false;
            touchCount = 0;
        }
    }
}
