using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class WebGLendAdapter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        VideoPlayer vp = GetComponent<VideoPlayer>();
        if (vp)
        {
            vp.url = Application.streamingAssetsPath + "/" + "NGGYU.mp4";
            vp.Prepare();
            vp.Play();
        }
    }
}
