using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ArreyCheck : MonoBehaviour
{
    public GameObject[] rayIndex;
    public GameObject[] answerIndex = new GameObject[9];

    int cnt = 0;

    bool arreyCompare = false;

    public void CheckCube()
    {
        if(cnt != 0)
        {
            cnt = 0;
        }

        for (int i = 0; i < rayIndex.Length; i++)
        {
            Ray ray = new Ray(rayIndex[i].gameObject.transform.position,
                                rayIndex[i].gameObject.transform.forward * 10f);
            RaycastHit hit;
            Debug.DrawRay(rayIndex[i].transform.position, rayIndex[i].transform.forward * 10, Color.yellow);
            if (Physics.Raycast(ray, out hit, 10f, 1<<8))
            {
                print("검출" + rayIndex[i]);
                // answerIndex[0] = hit.collider.gameObject;

                if (rayIndex[i].layer == answerIndex[i].layer)
                {
                    ++cnt;
                    print("카운트" +cnt);
                    // arreyCompare = rayIndex.SequenceEqual(answerIndex); 배열간 비교
                    if (cnt ==3)
                    {
                        print("정답");
                    }
                }
            }
        }
    }
    
}
