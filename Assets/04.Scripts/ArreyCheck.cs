using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArreyCheck : MonoBehaviour
{
    public GameObject[] rayIndex;
    public GameObject[] answerIndex = new GameObject[9];

    int cnt = 0;

    public void CheckCube()
    {
        for (int i = 0; i < rayIndex.Length; i++)
        {
            Ray ray = new Ray(rayIndex[i].gameObject.transform.position,
                                rayIndex[i].gameObject.transform.forward* 10f);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit,10f,1<<8))
            {
                print("검출" + rayIndex[i]);
                // answerIndex[0] = hit.collider.gameObject;

                if (rayIndex[i].layer == answerIndex[i].layer)
                {
                    ++cnt;
                    print("카운트" +cnt);

                    if (cnt == 3f)
                    {
                        print("정답");
                    }
                }
            }
        }
    }
    
}
