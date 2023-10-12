using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class CutsceneController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string nextSceneName;

    void Start()
    {
        videoPlayer.loopPointReached += EndVideo;
        videoPlayer.Play();
    }

    void EndVideo(VideoPlayer vp)
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
