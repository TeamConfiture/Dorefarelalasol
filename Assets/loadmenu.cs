using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class loadmenu : MonoBehaviour
{
    void Awake()
    {
        VideoPlayer vp = GetComponent<VideoPlayer>();
        vp.loopPointReached += EndReached;
    }


    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
            EndReached(null);
    }

    void EndReached(VideoPlayer vp)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
