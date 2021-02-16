using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NoteBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if (transform.position.y > -6.5) {
            
            transform.position = new Vector3(transform.position.x, Convert.ToSingle(transform.position.y -  0.005 * 1), transform.position.z);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
       /* if (collision.tag == "Player")
         {
            Debug.Log("Touched by player");
        }*/
        Debug.Log("Touched");
        Destroy(gameObject);
    }
}

