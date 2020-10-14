using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoCtrl : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    float currentTime;
    [Range(1, 5)]
    public float creatTime = 1f;
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    void Update()
    {
        if (videoPlayer.isPrepared && videoPlayer.isPlaying == false)
        {
            currentTime += Time.deltaTime;
            if (currentTime >= creatTime)
            {
                Debug.Log("영상 끝");
                SceneManager.LoadScene("PenelTest");
            }
        }
    }


    //영상이 끝났는지 확인
    //private bool isFinished = false;
    //public float timer = 1.0f;

    //private void Update()
    //{
    //    if (isFinished == false && videoPlayer.isPrepared && videoPlayer.isPlaying == false)
    //    {
    //        Debug.Log("영상 끝");
    //        isFinished = true;
    //        Invoke("ChangeScene", timer);
    //    }
    //}

    void ChangeScene()
    {
        SceneManager.LoadScene("Test");
    }
}
