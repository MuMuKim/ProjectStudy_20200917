using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class TouchMgr : MonoBehaviour
{
    public Camera ARCamera;
    public GameObject placeObj;

    public GameObject gameBoard;

    public int cnt = 0;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 0) return;

        Touch touch = Input.GetTouch(0);

        // ARCore 에서 제공하는 RaycastHit와 유사한 구조체
        TrackableHit hit;

        // 검출 대상을 평면 또는 Feater Point로 한정
        TrackableHitFlags raycastFilter = TrackableHitFlags.PlaneWithinPolygon | TrackableHitFlags.FeaturePointWithSurfaceNormal;

        // 터치한 지점으로 레이 발사
        if (cnt !=1 &&touch.phase == TouchPhase.Began && Frame.Raycast(touch.position.x
                                                         , touch.position.y
                                                         , raycastFilter
                                                         , out hit))
        {
            // 객체를 고정할 앵커를 생성
            var anchor = hit.Trackable.CreateAnchor(hit.Pose);
            // 객체를 생성
            gameBoard = Instantiate(placeObj
                                  , hit.Pose.position
                                  , Quaternion.identity
                                  , anchor.transform);
            cnt++;

            // 생성한 객체가 사용자 쪽으로 바라도록 회전값 계산
            var rot = Quaternion.LookRotation(ARCamera.transform.position - hit.Pose.position);

            // 사용자 쪽 회전값 적용
            gameBoard.transform.rotation = Quaternion.Euler(ARCamera.transform.position.x
                                                      , rot.eulerAngles.y
                                                      , ARCamera.transform.position.z);


        }
    }
}
