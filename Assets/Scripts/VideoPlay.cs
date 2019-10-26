using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoPlay : MonoBehaviour
{
    VideoPlayer video; 
    // Start is called before the first frame update
    void Start()
    {
        video = GetComponent<VideoPlayer>();
        video.loopPointReached += CheckOver;
    }

    // Update is called once per frame
    void Update()
    {
        //long playerCurFrame = video.frame;
        //long playerFrameTotal = Convert.ToInt64(video.frameCount);

        //bool isPlaying = playerCurFrame < playerFrameTotal;

    }

    void CheckOver(VideoPlayer v) 
    {
        Destroy(gameObject);
    }
}
