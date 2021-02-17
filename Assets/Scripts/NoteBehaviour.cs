using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class NoteBehaviour : MonoBehaviour
{

    public GameObject goal = null;

    public float speed =10.0f;

    // Start is called before the first frame update
    void Start()
    {
        if (goal == null)               //Used to prevent error form door spawn at the moment (commit 518afd5cefe7c79ec89f0c854c23438e2dc45f00)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {   

        this.transform.position = Vector3.MoveTowards(this.transform.position,goal.transform.position,speed * Time.deltaTime);
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
       if (collision.tag == "Player")
         {
             level_init.instance.ScoreUpdate();
            Debug.Log("Touched by player");
        }
        /*
        else{
            Debug.Log(this.transform.position);
            Debug.LogError("Touched by something else");
        }
        */
        Destroy(gameObject);
    }
}

