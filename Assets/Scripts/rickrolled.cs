using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rickrolled : MonoBehaviour
{
    public GameObject rick;
    bool playrick = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= 3 && !playrick)
        {
            playrick = true;
            rick.SetActive(true);
        }
    }
}
