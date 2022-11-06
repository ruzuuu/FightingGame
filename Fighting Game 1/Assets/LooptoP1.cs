using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class LooptoP1 : MonoBehaviour
{
    VideoPlayer video;
    
    void Awake() {
        video = GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += CheckOver;
    }
    
    void CheckOver(UnityEngine.Video.VideoPlayer VP) {
        SceneManager.LoadScene(2);
    }
}
