using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class loadmenu : MonoBehaviour
{
    void Awake()
    {
        VideoPlayer vp = GetComponent<VideoPlayer>();
        if (vp)
        {
            vp.url = Application.streamingAssetsPath + "/" + "dodosol2.webm";
            vp.Prepare();
            vp.Play();
        }
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
